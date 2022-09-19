using System.Windows.Forms;

namespace Rclone_Mount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRemotes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDrive = new System.Windows.Forms.ComboBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkNetworkMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lblBathMode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkCacheMode = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCacheDir = new System.Windows.Forms.Label();
            this.cbBatchMode = new System.Windows.Forms.ComboBox();
            this.nudCacheTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCacheMode = new System.Windows.Forms.ComboBox();
            this.nudMaxAge = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCache = new System.Windows.Forms.TextBox();
            this.btnCache = new System.Windows.Forms.Button();
            this.fbdCache = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCacheTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 2, 21);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbRemotes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbDrive, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkReadOnly, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.chkNetworkMode, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPath, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBathMode, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.lnkCacheMode, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.lblCacheDir, 1, 19);
            this.tableLayoutPanel1.Controls.Add(this.cbBatchMode, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.nudCacheTime, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 13);
            this.tableLayoutPanel1.Controls.Add(this.cbCacheMode, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.nudMaxAge, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 17);
            this.tableLayoutPanel1.Controls.Add(this.tbCache, 2, 19);
            this.tableLayoutPanel1.Controls.Add(this.btnCache, 4, 19);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 24;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 549);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnStart, 3);
            this.btnStart.Location = new System.Drawing.Point(357, 501);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remote:";
            // 
            // cbRemotes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbRemotes, 2);
            this.cbRemotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRemotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemotes.FormattingEnabled = true;
            this.cbRemotes.Location = new System.Drawing.Point(106, 23);
            this.cbRemotes.Name = "cbRemotes";
            this.cbRemotes.Size = new System.Drawing.Size(295, 23);
            this.cbRemotes.Sorted = true;
            this.cbRemotes.TabIndex = 1;
            this.cbRemotes.SelectedIndexChanged += new System.EventHandler(this.cbRemotes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drive:";
            // 
            // cbDrive
            // 
            this.cbDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrive.FormattingEnabled = true;
            this.cbDrive.Items.AddRange(new object[] {
            "A:",
            "B:",
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:",
            "J:",
            "K:",
            "L:",
            "M:",
            "N:",
            "O:",
            "P:",
            "Q:",
            "R:",
            "S:",
            "T:",
            "U:",
            "V:",
            "W:",
            "X:",
            "Y:",
            "Z:"});
            this.cbDrive.Location = new System.Drawing.Point(106, 121);
            this.cbDrive.Name = "cbDrive";
            this.cbDrive.Size = new System.Drawing.Size(121, 23);
            this.cbDrive.TabIndex = 5;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Checked = true;
            this.chkReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadOnly.Location = new System.Drawing.Point(106, 170);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(80, 19);
            this.chkReadOnly.TabIndex = 6;
            this.chkReadOnly.Text = "Read Only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // chkNetworkMode
            // 
            this.chkNetworkMode.AutoSize = true;
            this.chkNetworkMode.Checked = true;
            this.chkNetworkMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNetworkMode.Location = new System.Drawing.Point(106, 215);
            this.chkNetworkMode.Name = "chkNetworkMode";
            this.chkNetworkMode.Size = new System.Drawing.Size(105, 19);
            this.chkNetworkMode.TabIndex = 7;
            this.chkNetworkMode.Text = "Network Mode";
            this.chkNetworkMode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path:";
            // 
            // tbPath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbPath, 2);
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPath.Location = new System.Drawing.Point(106, 72);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(295, 23);
            this.tbPath.TabIndex = 3;
            // 
            // lblBathMode
            // 
            this.lblBathMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBathMode.AutoSize = true;
            this.lblBathMode.Location = new System.Drawing.Point(23, 264);
            this.lblBathMode.Name = "lblBathMode";
            this.lblBathMode.Size = new System.Drawing.Size(74, 15);
            this.lblBathMode.TabIndex = 21;
            this.lblBathMode.Text = "Batch Mode:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cache Time:";
            // 
            // lnkCacheMode
            // 
            this.lnkCacheMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkCacheMode.AutoSize = true;
            this.lnkCacheMode.Location = new System.Drawing.Point(23, 360);
            this.lnkCacheMode.Name = "lnkCacheMode";
            this.lnkCacheMode.Size = new System.Drawing.Size(77, 15);
            this.lnkCacheMode.TabIndex = 11;
            this.lnkCacheMode.TabStop = true;
            this.lnkCacheMode.Text = "Cache Mode:";
            this.lnkCacheMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCacheMode_LinkClicked);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max Age:";
            // 
            // lblCacheDir
            // 
            this.lblCacheDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCacheDir.AutoSize = true;
            this.lblCacheDir.Enabled = false;
            this.lblCacheDir.Location = new System.Drawing.Point(23, 456);
            this.lblCacheDir.Name = "lblCacheDir";
            this.lblCacheDir.Size = new System.Drawing.Size(43, 15);
            this.lblCacheDir.TabIndex = 16;
            this.lblCacheDir.Text = "Cache:";
            // 
            // cbBatchMode
            // 
            this.cbBatchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBatchMode.FormattingEnabled = true;
            this.cbBatchMode.Items.AddRange(new object[] {
            "Off",
            "Sync",
            "Async"});
            this.cbBatchMode.Location = new System.Drawing.Point(106, 260);
            this.cbBatchMode.Name = "cbBatchMode";
            this.cbBatchMode.Size = new System.Drawing.Size(121, 23);
            this.cbBatchMode.TabIndex = 22;
            // 
            // nudCacheTime
            // 
            this.nudCacheTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCacheTime.Location = new System.Drawing.Point(106, 309);
            this.nudCacheTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCacheTime.Name = "nudCacheTime";
            this.nudCacheTime.Size = new System.Drawing.Size(120, 23);
            this.nudCacheTime.TabIndex = 9;
            this.nudCacheTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCacheTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minutes";
            // 
            // cbCacheMode
            // 
            this.cbCacheMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCacheMode.FormattingEnabled = true;
            this.cbCacheMode.Items.AddRange(new object[] {
            "Off",
            "Minimal",
            "Writes",
            "Full"});
            this.cbCacheMode.Location = new System.Drawing.Point(106, 358);
            this.cbCacheMode.Name = "cbCacheMode";
            this.cbCacheMode.Size = new System.Drawing.Size(121, 23);
            this.cbCacheMode.TabIndex = 12;
            this.cbCacheMode.SelectedIndexChanged += new System.EventHandler(this.cbCacheMode_SelectedIndexChanged);
            // 
            // nudMaxAge
            // 
            this.nudMaxAge.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMaxAge.Location = new System.Drawing.Point(106, 403);
            this.nudMaxAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxAge.Name = "nudMaxAge";
            this.nudMaxAge.Size = new System.Drawing.Size(120, 23);
            this.nudMaxAge.TabIndex = 14;
            this.nudMaxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxAge.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Minutes";
            // 
            // tbCache
            // 
            this.tbCache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCache.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCache.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.tableLayoutPanel1.SetColumnSpan(this.tbCache, 2);
            this.tbCache.Enabled = false;
            this.tbCache.Location = new System.Drawing.Point(106, 452);
            this.tbCache.Name = "tbCache";
            this.tbCache.Size = new System.Drawing.Size(295, 23);
            this.tbCache.TabIndex = 17;
            // 
            // btnCache
            // 
            this.btnCache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCache.Enabled = false;
            this.btnCache.Location = new System.Drawing.Point(407, 452);
            this.btnCache.Name = "btnCache";
            this.btnCache.Size = new System.Drawing.Size(25, 23);
            this.btnCache.TabIndex = 18;
            this.btnCache.Text = "...";
            this.btnCache.UseVisualStyleBackColor = true;
            this.btnCache.Click += new System.EventHandler(this.btnCache_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rclone Mount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCacheTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox cbDrive;
        private CheckBox chkReadOnly;
        private Label lblCacheDir;
        private TextBox tbCache;
        private Button btnCache;
        private Button btnStart;
        private FolderBrowserDialog fbdCache;
        private Label label3;
        private ComboBox cbRemotes;
        private CheckBox chkNetworkMode;
        private Label label4;
        private NumericUpDown nudCacheTime;
        private ComboBox cbCacheMode;
        private LinkLabel lnkCacheMode;
        private Label label2;
        private TextBox tbPath;
        private Label label5;
        private Label label6;
        private NumericUpDown nudMaxAge;
        private Label label7;
        private Label lblBathMode;
        private ComboBox cbBatchMode;
    }
}