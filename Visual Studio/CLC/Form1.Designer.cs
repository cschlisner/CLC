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
            this.sensitivityTB = new System.Windows.Forms.TrackBar();
            this.IntensityTB = new System.Windows.Forms.TrackBar();
            this.speedTB = new System.Windows.Forms.TrackBar();
            this.ON = new System.Windows.Forms.RadioButton();
            this.OFF = new System.Windows.Forms.RadioButton();
            this.LEVELS = new System.Windows.Forms.RadioButton();
            this.BEAT = new System.Windows.Forms.RadioButton();
            this.FADE = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.COMPortCB = new System.Windows.Forms.ComboBox();
            this.deviceCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTB)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sensitivityTB
            // 
            this.sensitivityTB.Location = new System.Drawing.Point(166, 88);
            this.sensitivityTB.Maximum = 900;
            this.sensitivityTB.Minimum = 300;
            this.sensitivityTB.Name = "sensitivityTB";
            this.sensitivityTB.Size = new System.Drawing.Size(224, 45);
            this.sensitivityTB.TabIndex = 2;
            this.sensitivityTB.TickFrequency = 50;
            this.sensitivityTB.Value = 450;
            this.sensitivityTB.Scroll += new System.EventHandler(this.sensitivityTB_Scroll);
            // 
            // IntensityTB
            // 
            this.IntensityTB.LargeChange = 50;
            this.IntensityTB.Location = new System.Drawing.Point(166, 22);
            this.IntensityTB.Maximum = 255;
            this.IntensityTB.Name = "IntensityTB";
            this.IntensityTB.Size = new System.Drawing.Size(224, 45);
            this.IntensityTB.SmallChange = 10;
            this.IntensityTB.TabIndex = 3;
            this.IntensityTB.TickFrequency = 20;
            this.IntensityTB.Value = 255;
            this.IntensityTB.Scroll += new System.EventHandler(this.IntensityTB_Scroll);
            // 
            // speedTB
            // 
            this.speedTB.Location = new System.Drawing.Point(166, 158);
            this.speedTB.Maximum = 50;
            this.speedTB.Minimum = 1;
            this.speedTB.Name = "speedTB";
            this.speedTB.Size = new System.Drawing.Size(224, 45);
            this.speedTB.TabIndex = 4;
            this.speedTB.TickFrequency = 5;
            this.speedTB.Value = 3;
            this.speedTB.Scroll += new System.EventHandler(this.speedTB_Scroll);
            // 
            // ON
            // 
            this.ON.AutoSize = true;
            this.ON.Checked = true;
            this.ON.Location = new System.Drawing.Point(12, 27);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(41, 17);
            this.ON.TabIndex = 9;
            this.ON.TabStop = true;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OFF
            // 
            this.OFF.AutoSize = true;
            this.OFF.Location = new System.Drawing.Point(12, 50);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(45, 17);
            this.OFF.TabIndex = 10;
            this.OFF.TabStop = true;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LEVELS
            // 
            this.LEVELS.AutoSize = true;
            this.LEVELS.Location = new System.Drawing.Point(12, 73);
            this.LEVELS.Name = "LEVELS";
            this.LEVELS.Size = new System.Drawing.Size(77, 17);
            this.LEVELS.TabIndex = 11;
            this.LEVELS.TabStop = true;
            this.LEVELS.Text = "Bass Level";
            this.LEVELS.UseVisualStyleBackColor = true;
            this.LEVELS.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BEAT
            // 
            this.BEAT.AutoSize = true;
            this.BEAT.Location = new System.Drawing.Point(12, 96);
            this.BEAT.Name = "BEAT";
            this.BEAT.Size = new System.Drawing.Size(47, 17);
            this.BEAT.TabIndex = 12;
            this.BEAT.TabStop = true;
            this.BEAT.Text = "Beat";
            this.BEAT.UseVisualStyleBackColor = true;
            this.BEAT.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // FADE
            // 
            this.FADE.AutoSize = true;
            this.FADE.Location = new System.Drawing.Point(12, 119);
            this.FADE.Name = "FADE";
            this.FADE.Size = new System.Drawing.Size(49, 17);
            this.FADE.TabIndex = 13;
            this.FADE.TabStop = true;
            this.FADE.Text = "Fade";
            this.FADE.UseVisualStyleBackColor = true;
            this.FADE.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Intensity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sensitivity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Speed";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Case Lights";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 186);
            // 
            // toolStripOn
            // 
            this.toolStripOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOn.Name = "toolStripOn";
            this.toolStripOn.Size = new System.Drawing.Size(127, 22);
            this.toolStripOn.Text = "On";
            this.toolStripOn.Visible = false;
            this.toolStripOn.Click += new System.EventHandler(this.toolStripOn_Click);
            // 
            // toolStripOff
            // 
            this.toolStripOff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOff.Name = "toolStripOff";
            this.toolStripOff.Size = new System.Drawing.Size(127, 22);
            this.toolStripOff.Text = "Off";
            this.toolStripOff.Click += new System.EventHandler(this.toolStripOff_Click);
            // 
            // toolStripBass
            // 
            this.toolStripBass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBass.Name = "toolStripBass";
            this.toolStripBass.Size = new System.Drawing.Size(127, 22);
            this.toolStripBass.Text = "Bass";
            this.toolStripBass.Click += new System.EventHandler(this.toolStripBass_Click);
            // 
            // toolStripBeat
            // 
            this.toolStripBeat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBeat.Name = "toolStripBeat";
            this.toolStripBeat.Size = new System.Drawing.Size(127, 22);
            this.toolStripBeat.Text = "Beat";
            this.toolStripBeat.Click += new System.EventHandler(this.toolStripBeat_Click);
            // 
            // toolStripFade
            // 
            this.toolStripFade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFade.Name = "toolStripFade";
            this.toolStripFade.Size = new System.Drawing.Size(127, 22);
            this.toolStripFade.Text = "Fade";
            this.toolStripFade.Click += new System.EventHandler(this.toolStripFade_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(127, 22);
            this.toolStripSettings.Text = "Settings";
            this.toolStripSettings.Click += new System.EventHandler(this.toolStripSettings_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(127, 22);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // COMPortCB
            // 
            this.COMPortCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortCB.FormattingEnabled = true;
            this.COMPortCB.Location = new System.Drawing.Point(12, 170);
            this.COMPortCB.Name = "COMPortCB";
            this.COMPortCB.Size = new System.Drawing.Size(121, 21);
            this.COMPortCB.TabIndex = 17;
            this.COMPortCB.SelectedIndexChanged += new System.EventHandler(this.COMPortCB_SelectedIndexChanged);
            // 
            // deviceCB
            // 
            this.deviceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceCB.FormattingEnabled = true;
            this.deviceCB.Location = new System.Drawing.Point(12, 143);
            this.deviceCB.Name = "deviceCB";
            this.deviceCB.Size = new System.Drawing.Size(121, 21);
            this.deviceCB.TabIndex = 18;
            this.deviceCB.SelectedIndexChanged += new System.EventHandler(this.deviceCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 198);
            this.Controls.Add(this.deviceCB);
            this.Controls.Add(this.COMPortCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FADE);
            this.Controls.Add(this.BEAT);
            this.Controls.Add(this.LEVELS);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.speedTB);
            this.Controls.Add(this.IntensityTB);
            this.Controls.Add(this.sensitivityTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Case Lights Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTB)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sensitivityTB;
        private System.Windows.Forms.TrackBar IntensityTB;
        private System.Windows.Forms.TrackBar speedTB;
        private System.Windows.Forms.RadioButton ON;
        private System.Windows.Forms.RadioButton OFF;
        private System.Windows.Forms.RadioButton LEVELS;
        private System.Windows.Forms.RadioButton BEAT;
        private System.Windows.Forms.RadioButton FADE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ComboBox COMPortCB;
        private System.Windows.Forms.ComboBox deviceCB;
    }
}

