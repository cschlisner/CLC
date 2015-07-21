namespace CLC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBeat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceCB = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Case Lights";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOn,
            this.toolStripOff,
            this.toolStripBass,
            this.toolStripBeat,
            this.toolStripFade,
            this.toolStripSeparator2,
            this.toolStripSettings,
            this.toolStripExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(92, 164);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // toolStripOn
            // 
            this.toolStripOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOn.Name = "toolStripOn";
            this.toolStripOn.Size = new System.Drawing.Size(91, 22);
            this.toolStripOn.Text = "On";
            this.toolStripOn.Click += new System.EventHandler(this.toolStripOn_Click);
            // 
            // toolStripOff
            // 
            this.toolStripOff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOff.Name = "toolStripOff";
            this.toolStripOff.Size = new System.Drawing.Size(91, 22);
            this.toolStripOff.Text = "Off";
            this.toolStripOff.Click += new System.EventHandler(this.toolStripOff_Click);
            // 
            // toolStripBass
            // 
            this.toolStripBass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBass.Name = "toolStripBass";
            this.toolStripBass.Size = new System.Drawing.Size(91, 22);
            this.toolStripBass.Text = "Bass";
            this.toolStripBass.Click += new System.EventHandler(this.toolStripBass_Click);
            // 
            // toolStripBeat
            // 
            this.toolStripBeat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBeat.Name = "toolStripBeat";
            this.toolStripBeat.Size = new System.Drawing.Size(91, 22);
            this.toolStripBeat.Text = "Beat";
            this.toolStripBeat.Click += new System.EventHandler(this.toolStripBeat_Click);
            // 
            // toolStripFade
            // 
            this.toolStripFade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFade.Name = "toolStripFade";
            this.toolStripFade.Size = new System.Drawing.Size(91, 22);
            this.toolStripFade.Text = "Fade";
            this.toolStripFade.Click += new System.EventHandler(this.toolStripFade_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(88, 6);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(91, 22);
            this.toolStripSettings.Text = "Settings";
            this.toolStripSettings.Click += new System.EventHandler(this.toolStripSettings_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(91, 22);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // deviceCB
            // 
            this.deviceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceCB.FormattingEnabled = true;
            this.deviceCB.Location = new System.Drawing.Point(12, 12);
            this.deviceCB.Name = "deviceCB";
            this.deviceCB.Size = new System.Drawing.Size(121, 21);
            this.deviceCB.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 0);
            this.Controls.Add(this.deviceCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Case Lights Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripOn;
        private System.Windows.Forms.ToolStripMenuItem toolStripOff;
        private System.Windows.Forms.ToolStripMenuItem toolStripBass;
        private System.Windows.Forms.ToolStripMenuItem toolStripBeat;
        private System.Windows.Forms.ToolStripMenuItem toolStripFade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ComboBox deviceCB;
    }
}

