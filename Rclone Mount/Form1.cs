using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rclone_Mount
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _remoteTypes = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            Icon = Properties.Resources.logo_symbol_color;
            chkReadOnly.Checked = true;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            var settings = Properties.Settings.Default;

            try { cbDrive.SelectedItem = settings.Drive; }
            catch { }
            if (cbDrive.SelectedIndex < 0)
                cbDrive.SelectedIndex = cbDrive.Items.Count - 1;

            tbCache.Text = settings.Cache;
            
            var lst = (await RunRclone("listremotes")).Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in lst)
                cbRemotes.Items.Add(item);

            if (cbRemotes.Items.Count > 0)
            {
                var json = await RunRclone("config dump");
                var nodes = JsonNode.Parse(json);
                foreach (string item in lst)
                {
                    var node = nodes[item[..^1]];
                    _remoteTypes.Add(item, node["type"].GetValue<string>());
                }

                foreach (var kvp in _remoteTypes.Where(item => item.Value == "crypt").ToList())
                {
                    var node = nodes[kvp.Key[..^1]];
                    string remote = node["remote"].GetValue<string>();
                    remote = remote[0..(remote.IndexOf(":") + 1)];
                    _remoteTypes[kvp.Key] = _remoteTypes[remote];
                }
            }

            
            try { cbRemotes.SelectedItem = settings.Remote; }
            catch { }
            if (cbRemotes.SelectedIndex < 0 && cbRemotes.Items.Count > 0)
                cbRemotes.SelectedIndex = 0;



            tbPath.Text = settings.Path;


            chkNetworkMode.Checked = settings.NetworkMode;

            nudCacheTime.Value = settings.CacheTime;
            try { cbCacheMode.SelectedItem = settings.CacheMode; }
            catch { cbCacheMode.SelectedIndex = 0; }
            cbCacheMode_SelectedIndexChanged(cbCacheMode, EventArgs.Empty);

            nudMaxAge.Value = settings.MaxAge;

            try { cbBatchMode.SelectedItem = settings.DropBoxBatchMode; }
            catch { cbBatchMode.SelectedIndex = 1; }

            EnableControls(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settings = Properties.Settings.Default;
            settings.Drive = cbDrive.SelectedItem as string;
            settings.Cache = tbCache.Text;
            settings.Remote = cbRemotes.SelectedItem as string;
            settings.NetworkMode = chkNetworkMode.Checked;
            settings.CacheMode = cbCacheMode.SelectedItem as string;
            settings.CacheTime = (int)nudCacheTime.Value;
            settings.Path = tbPath.Text;
            settings.MaxAge = (int)nudMaxAge.Value;
            settings.DropBoxBatchMode = cbBatchMode.SelectedItem as string;
            settings.Save();
        }


        private void cbRemotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDropboxBatchMode();
        }

        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            EnableDropboxBatchMode();
        }

        private void lnkCacheMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://rclone.org/commands/rclone_mount/#vfs-file-caching",
                UseShellExecute = true
            });
        }

        private void cbCacheMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enabled = cbCacheMode.SelectedIndex > 0;
            lblCacheDir.Enabled = enabled;
            tbCache.Enabled = enabled;
            btnCache.Enabled = enabled;
        }

        private void btnCache_Click(object sender, EventArgs e)
        {
            fbdCache.SelectedPath = tbCache.Text;
            if (fbdCache.ShowDialog() == DialogResult.OK)
                tbCache.Text = fbdCache.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string args = "mount \"" + cbRemotes.SelectedItem + tbPath.Text.Trim() + "\"";
            args += " " + cbDrive.SelectedItem;

            if (chkNetworkMode.Checked)
                args += " --network-mode";
            
            if (chkReadOnly.Checked)
                args += " --read-only";

            if (cbBatchMode.Enabled && cbBatchMode.SelectedIndex > 0)
                args += " --dropbox-batch-mode " + (cbBatchMode.SelectedItem as string).ToLower(); ;

            if (nudCacheTime.Value != 5)
                args += $" --dir-cache-time {nudCacheTime.Value}m";

            if(cbCacheMode.SelectedIndex > 0)
            {
                args += " --vfs-cache-mode " + ((string)cbCacheMode.SelectedItem).ToLower();

                if (nudMaxAge.Value != 60)
                    args += $" --vfs-cache-max-age {nudMaxAge.Value}m";

                if (!string.IsNullOrWhiteSpace(tbCache.Text))
                    args += $" --cache-dir \"{tbCache.Text}\"";
            }


            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "rclone.exe",
                    Arguments = args,
                    RedirectStandardError = true
                }
            };

            proc.Start();
            string line = proc.StandardError.ReadLine();
            if (line == "The service rclone has been started.")
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = (cbDrive.SelectedItem as string) + "\\",
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show(line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }














        private void EnableControls(bool enabled)
        {
            tableLayoutPanel1.Enabled = enabled;
            UseWaitCursor = !enabled;
        }

        private void EnableDropboxBatchMode()
        {
            bool enableBatch = cbRemotes.SelectedIndex >= 0 && 
                _remoteTypes[cbRemotes.SelectedItem as string] == "dropbox"
                && chkReadOnly.Checked == false;

            lblBathMode.Enabled = enableBatch;
            cbBatchMode.Enabled = enableBatch;
        }

        private static async Task<string> RunRclone(string args)
        {
            var proc = Process.Start(new ProcessStartInfo
            {
                FileName = "rclone.exe",
                Arguments = args,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            });

            var task1 = proc.WaitForExitAsync();

            StringBuilder sbRet = new();
            var task2 = Task.Run(() =>
            {
                Span<char> buffer = new char[1024];
                while (true)
                {
                    int read = proc.StandardOutput.Read(buffer);
                    if (read < 1)
                        return;
                    sbRet.Append(buffer.Slice(0, read).ToString());
                }
            });

            StringBuilder sbErr = new();
            var task3 = Task.Run(() =>
            {
                Span<char> buffer = new char[1024];
                while (true)
                {
                    int read = proc.StandardError.Read(buffer);
                    if (read < 1)
                        return;
                    sbErr.Append(buffer.Slice(0, read).ToString());
                }
            });

            await Task.WhenAll(task1, task2, task3);

            if (proc.ExitCode != 0)
                throw new Exception(sbErr.ToString());

            return sbRet.ToString();
        }

       
    }
}