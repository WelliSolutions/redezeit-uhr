
namespace TalkingTimeKeeper
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtSpeakers = new System.Windows.Forms.TextBox();
            this.lblSpeakers = new System.Windows.Forms.Label();
            this.lblTalkingTime = new System.Windows.Forms.Label();
            this.txtTalkingTime = new System.Windows.Forms.TextBox();
            this.btnNextSpeaker = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblTalking = new System.Windows.Forms.Label();
            this.lblCurrentSpeaker = new System.Windows.Forms.Label();
            this.lblSpoken = new System.Windows.Forms.Label();
            this.lblToSpeak = new System.Windows.Forms.Label();
            this.tmrTalkingTime = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrTickingSeconds = new System.Windows.Forms.Timer(this.components);
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnNextSpeakerSmall = new System.Windows.Forms.Button();
            this.btnStopSmall = new System.Windows.Forms.Button();
            this.btnSmallWindow = new System.Windows.Forms.Button();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSpeakers
            // 
            this.txtSpeakers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpeakers.Location = new System.Drawing.Point(12, 25);
            this.txtSpeakers.Name = "txtSpeakers";
            this.txtSpeakers.Size = new System.Drawing.Size(189, 20);
            this.txtSpeakers.TabIndex = 1;
            this.txtSpeakers.Text = "Mario Luigi Peach Bowser Yoshi";
            // 
            // lblSpeakers
            // 
            this.lblSpeakers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeakers.AutoSize = true;
            this.lblSpeakers.Location = new System.Drawing.Point(12, 9);
            this.lblSpeakers.Name = "lblSpeakers";
            this.lblSpeakers.Size = new System.Drawing.Size(181, 13);
            this.lblSpeakers.TabIndex = 0;
            this.lblSpeakers.Text = "&Redner (getrennt durch Leerzeichen)";
            // 
            // lblTalkingTime
            // 
            this.lblTalkingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTalkingTime.AutoSize = true;
            this.lblTalkingTime.Location = new System.Drawing.Point(12, 48);
            this.lblTalkingTime.Name = "lblTalkingTime";
            this.lblTalkingTime.Size = new System.Drawing.Size(124, 13);
            this.lblTalkingTime.TabIndex = 2;
            this.lblTalkingTime.Text = "&Zeit (Minuten:Sekunden)";
            // 
            // txtTalkingTime
            // 
            this.txtTalkingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTalkingTime.Location = new System.Drawing.Point(12, 64);
            this.txtTalkingTime.Name = "txtTalkingTime";
            this.txtTalkingTime.Size = new System.Drawing.Size(189, 20);
            this.txtTalkingTime.TabIndex = 3;
            this.txtTalkingTime.Text = "2:00";
            // 
            // btnNextSpeaker
            // 
            this.btnNextSpeaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextSpeaker.Location = new System.Drawing.Point(12, 90);
            this.btnNextSpeaker.Name = "btnNextSpeaker";
            this.btnNextSpeaker.Size = new System.Drawing.Size(189, 23);
            this.btnNextSpeaker.TabIndex = 4;
            this.btnNextSpeaker.Text = "&Nächster Sprecher";
            this.btnNextSpeaker.UseVisualStyleBackColor = true;
            this.btnNextSpeaker.Click += new System.EventHandler(this.btnNextSpeaker_Click);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(264, 83);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(171, 45);
            this.lblTimeLeft.TabIndex = 12;
            this.lblTimeLeft.Text = "-:--";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTalking
            // 
            this.lblTalking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTalking.Location = new System.Drawing.Point(268, 27);
            this.lblTalking.Name = "lblTalking";
            this.lblTalking.Size = new System.Drawing.Size(167, 23);
            this.lblTalking.TabIndex = 10;
            this.lblTalking.Text = "Es spricht:";
            this.lblTalking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentSpeaker
            // 
            this.lblCurrentSpeaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentSpeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSpeaker.Location = new System.Drawing.Point(264, 44);
            this.lblCurrentSpeaker.Name = "lblCurrentSpeaker";
            this.lblCurrentSpeaker.Size = new System.Drawing.Size(171, 45);
            this.lblCurrentSpeaker.TabIndex = 11;
            this.lblCurrentSpeaker.Text = "--";
            this.lblCurrentSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpoken
            // 
            this.lblSpoken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpoken.Location = new System.Drawing.Point(268, 5);
            this.lblSpoken.Name = "lblSpoken";
            this.lblSpoken.Size = new System.Drawing.Size(167, 23);
            this.lblSpoken.TabIndex = 9;
            this.lblSpoken.Text = "Es sprachen: ";
            this.lblSpoken.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblToSpeak
            // 
            this.lblToSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToSpeak.Location = new System.Drawing.Point(268, 131);
            this.lblToSpeak.Name = "lblToSpeak";
            this.lblToSpeak.Size = new System.Drawing.Size(167, 21);
            this.lblToSpeak.TabIndex = 13;
            this.lblToSpeak.Text = "Es folgen:";
            this.lblToSpeak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrTalkingTime
            // 
            this.tmrTalkingTime.Interval = 250;
            this.tmrTalkingTime.Tick += new System.EventHandler(this.TimerTick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(12, 119);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(189, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrTickingSeconds
            // 
            this.tmrTickingSeconds.Interval = 1000;
            this.tmrTickingSeconds.Tick += new System.EventHandler(this.tmrTickingSeconds_Tick);
            // 
            // trkVolume
            // 
            this.trkVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trkVolume.AutoSize = false;
            this.trkVolume.LargeChange = 20;
            this.trkVolume.Location = new System.Drawing.Point(207, 25);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVolume.Size = new System.Drawing.Size(20, 146);
            this.trkVolume.SmallChange = 5;
            this.trkVolume.TabIndex = 8;
            this.trkVolume.TickFrequency = 5;
            this.trkVolume.Value = 50;
            this.trkVolume.Scroll += new System.EventHandler(this.OnVolumeChange);
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(211, 5);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(15, 13);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "🔈";
            // 
            // btnNextSpeakerSmall
            // 
            this.btnNextSpeakerSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextSpeakerSmall.Location = new System.Drawing.Point(233, 90);
            this.btnNextSpeakerSmall.Name = "btnNextSpeakerSmall";
            this.btnNextSpeakerSmall.Size = new System.Drawing.Size(25, 23);
            this.btnNextSpeakerSmall.TabIndex = 14;
            this.btnNextSpeakerSmall.Text = "▶";
            this.btnNextSpeakerSmall.UseVisualStyleBackColor = true;
            this.btnNextSpeakerSmall.Visible = false;
            this.btnNextSpeakerSmall.Click += new System.EventHandler(this.btnNextSpeaker_Click);
            // 
            // btnStopSmall
            // 
            this.btnStopSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopSmall.Location = new System.Drawing.Point(233, 119);
            this.btnStopSmall.Name = "btnStopSmall";
            this.btnStopSmall.Size = new System.Drawing.Size(25, 23);
            this.btnStopSmall.TabIndex = 15;
            this.btnStopSmall.Text = "⏹";
            this.btnStopSmall.UseVisualStyleBackColor = true;
            this.btnStopSmall.Visible = false;
            this.btnStopSmall.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSmallWindow
            // 
            this.btnSmallWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSmallWindow.Location = new System.Drawing.Point(233, 148);
            this.btnSmallWindow.Name = "btnSmallWindow";
            this.btnSmallWindow.Size = new System.Drawing.Size(25, 23);
            this.btnSmallWindow.TabIndex = 16;
            this.btnSmallWindow.Text = "«";
            this.btnSmallWindow.UseVisualStyleBackColor = true;
            this.btnSmallWindow.Click += new System.EventHandler(this.OnSmallWindow);
            // 
            // chkTopMost
            // 
            this.chkTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTopMost.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTopMost.Checked = true;
            this.chkTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopMost.Location = new System.Drawing.Point(264, 148);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(25, 24);
            this.chkTopMost.TabIndex = 17;
            this.chkTopMost.Text = "📌";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // chkShuffle
            // 
            this.chkShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShuffle.AutoSize = true;
            this.chkShuffle.Checked = true;
            this.chkShuffle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShuffle.Location = new System.Drawing.Point(12, 148);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(126, 17);
            this.chkShuffle.TabIndex = 6;
            this.chkShuffle.Text = "Zufällige Reihenf&olge";
            this.chkShuffle.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 176);
            this.Controls.Add(this.chkShuffle);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.btnSmallWindow);
            this.Controls.Add(this.btnStopSmall);
            this.Controls.Add(this.btnNextSpeakerSmall);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblToSpeak);
            this.Controls.Add(this.lblSpoken);
            this.Controls.Add(this.lblCurrentSpeaker);
            this.Controls.Add(this.lblTalking);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btnNextSpeaker);
            this.Controls.Add(this.txtTalkingTime);
            this.Controls.Add(this.lblTalkingTime);
            this.Controls.Add(this.lblSpeakers);
            this.Controls.Add(this.txtSpeakers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 215);
            this.MinimumSize = new System.Drawing.Size(261, 215);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redezeit-Uhr";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeakers;
        private System.Windows.Forms.Label lblSpeakers;
        private System.Windows.Forms.Label lblTalkingTime;
        private System.Windows.Forms.TextBox txtTalkingTime;
        private System.Windows.Forms.Button btnNextSpeaker;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblTalking;
        private System.Windows.Forms.Label lblCurrentSpeaker;
        private System.Windows.Forms.Label lblSpoken;
        private System.Windows.Forms.Label lblToSpeak;
        private System.Windows.Forms.Timer tmrTalkingTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrTickingSeconds;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnNextSpeakerSmall;
        private System.Windows.Forms.Button btnStopSmall;
        private System.Windows.Forms.Button btnSmallWindow;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

