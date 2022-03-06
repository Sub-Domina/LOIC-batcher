namespace LOIC_Batcher
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
            this.components = new System.ComponentModel.Container();
            this.attackButton = new System.Windows.Forms.Button();
            this.batchSettingGroup = new System.Windows.Forms.GroupBox();
            this.hiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.TrackBar();
            this.socketsLabel = new System.Windows.Forms.Label();
            this.sockets = new System.Windows.Forms.TextBox();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.openFileLOIC = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.targetCountLabel = new System.Windows.Forms.Label();
            this.targetCount = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.targetsPanel = new System.Windows.Forms.Panel();
            this.batchSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.attackButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.attackButton.Location = new System.Drawing.Point(632, 415);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 9;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // batchSettingGroup
            // 
            this.batchSettingGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.batchSettingGroup.Controls.Add(this.hiddenCheckBox);
            this.batchSettingGroup.Controls.Add(this.delayLabel);
            this.batchSettingGroup.Controls.Add(this.delay);
            this.batchSettingGroup.Controls.Add(this.socketsLabel);
            this.batchSettingGroup.Controls.Add(this.sockets);
            this.batchSettingGroup.Controls.Add(this.threadsLabel);
            this.batchSettingGroup.Controls.Add(this.threads);
            this.batchSettingGroup.ForeColor = System.Drawing.SystemColors.Info;
            this.batchSettingGroup.Location = new System.Drawing.Point(463, 12);
            this.batchSettingGroup.Name = "batchSettingGroup";
            this.batchSettingGroup.Size = new System.Drawing.Size(325, 149);
            this.batchSettingGroup.TabIndex = 10;
            this.batchSettingGroup.TabStop = false;
            this.batchSettingGroup.Text = "Batch setting";
            // 
            // hiddenCheckBox
            // 
            this.hiddenCheckBox.AutoSize = true;
            this.hiddenCheckBox.Location = new System.Drawing.Point(114, 41);
            this.hiddenCheckBox.Name = "hiddenCheckBox";
            this.hiddenCheckBox.Size = new System.Drawing.Size(144, 19);
            this.hiddenCheckBox.TabIndex = 0;
            this.hiddenCheckBox.Text = "Launch hidden (silent)";
            this.hiddenCheckBox.UseVisualStyleBackColor = true;
            this.hiddenCheckBox.CheckedChanged += new System.EventHandler(this.hiddenCheckBox_CheckedChanged);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.delayLabel.Location = new System.Drawing.Point(6, 63);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(36, 15);
            this.delayLabel.TabIndex = 5;
            this.delayLabel.Text = "Delay";
            // 
            // delay
            // 
            this.delay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delay.Location = new System.Drawing.Point(6, 81);
            this.delay.Maximum = 50;
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(313, 45);
            this.delay.TabIndex = 4;
            this.delay.Value = 10;
            this.delay.Scroll += new System.EventHandler(this.delay_Scroll);
            // 
            // socketsLabel
            // 
            this.socketsLabel.AutoSize = true;
            this.socketsLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.socketsLabel.Location = new System.Drawing.Point(60, 19);
            this.socketsLabel.Name = "socketsLabel";
            this.socketsLabel.Size = new System.Drawing.Size(47, 15);
            this.socketsLabel.TabIndex = 3;
            this.socketsLabel.Text = "Sockets";
            // 
            // sockets
            // 
            this.sockets.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sockets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sockets.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sockets.Location = new System.Drawing.Point(60, 37);
            this.sockets.Name = "sockets";
            this.sockets.Size = new System.Drawing.Size(48, 23);
            this.sockets.TabIndex = 2;
            this.sockets.Text = "100";
            this.sockets.TextChanged += new System.EventHandler(this.sockets_TextChanged);
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.threadsLabel.Location = new System.Drawing.Point(6, 19);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(48, 15);
            this.threadsLabel.TabIndex = 1;
            this.threadsLabel.Text = "Threads";
            // 
            // threads
            // 
            this.threads.BackColor = System.Drawing.SystemColors.ControlLight;
            this.threads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threads.ForeColor = System.Drawing.SystemColors.Highlight;
            this.threads.Location = new System.Drawing.Point(6, 37);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(48, 23);
            this.threads.TabIndex = 0;
            this.threads.Text = "40";
            this.threads.TextChanged += new System.EventHandler(this.threads_TextChanged);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.stopButton.Location = new System.Drawing.Point(713, 415);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.SystemColors.ControlLight;
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path.ForeColor = System.Drawing.SystemColors.Highlight;
            this.path.Location = new System.Drawing.Point(12, 27);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(360, 23);
            this.path.TabIndex = 12;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.pathLabel.Location = new System.Drawing.Point(12, 9);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(74, 15);
            this.pathLabel.TabIndex = 13;
            this.pathLabel.Text = "Path to LOIC";
            // 
            // openFileLOIC
            // 
            this.openFileLOIC.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileLOIC_FileOk);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.browseButton.Location = new System.Drawing.Point(378, 26);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 14;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // targetCountLabel
            // 
            this.targetCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetCountLabel.AutoSize = true;
            this.targetCountLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.targetCountLabel.Location = new System.Drawing.Point(86, 67);
            this.targetCountLabel.Name = "targetCountLabel";
            this.targetCountLabel.Size = new System.Drawing.Size(75, 15);
            this.targetCountLabel.TabIndex = 15;
            this.targetCountLabel.Text = "Target Count";
            // 
            // targetCount
            // 
            this.targetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.targetCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetCount.Location = new System.Drawing.Point(167, 64);
            this.targetCount.Name = "targetCount";
            this.targetCount.Size = new System.Drawing.Size(100, 23);
            this.targetCount.TabIndex = 16;
            this.targetCount.TextChanged += new System.EventHandler(this.targetCount_TextChanged);
            // 
            // targetsPanel
            // 
            this.targetsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetsPanel.AutoScroll = true;
            this.targetsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.targetsPanel.Location = new System.Drawing.Point(12, 93);
            this.targetsPanel.Name = "targetsPanel";
            this.targetsPanel.Size = new System.Drawing.Size(255, 345);
            this.targetsPanel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.targetsPanel);
            this.Controls.Add(this.targetCount);
            this.Controls.Add(this.targetCountLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.path);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.batchSettingGroup);
            this.Controls.Add(this.attackButton);
            this.Name = "Form1";
            this.Text = "LOIC Batcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.batchSettingGroup.ResumeLayout(false);
            this.batchSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button attackButton;
        private GroupBox batchSettingGroup;
        private TextBox threads;
        private Button stopButton;
        private Label threadsLabel;
        private Label delayLabel;
        private TrackBar delay;
        private Label socketsLabel;
        private TextBox sockets;
        private TextBox path;
        private Label pathLabel;
        private OpenFileDialog openFileLOIC;
        private Button browseButton;
        private Label targetCountLabel;
        private TextBox targetCount;
        private BindingSource bindingSource1;
        private Panel targetsPanel;
        private CheckBox hiddenCheckBox;
    }
}