namespace flyBird
{
    partial class AudioRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioRecorder));
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.playButton = new MetroFramework.Controls.MetroButton();
            this.sendButton = new MetroFramework.Controls.MetroButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.recordingIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recordingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseSelectable = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 38);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(102, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseSelectable = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(12, 65);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(399, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseSelectable = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(316, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(45, 24);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "time";
            // 
            // recordingIcon
            // 
            this.recordingIcon.Image = global::flyBird.Properties.Resources._48c99328741557_55cfd3c8be389;
            this.recordingIcon.Location = new System.Drawing.Point(206, 12);
            this.recordingIcon.Name = "recordingIcon";
            this.recordingIcon.Size = new System.Drawing.Size(60, 47);
            this.recordingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recordingIcon.TabIndex = 5;
            this.recordingIcon.TabStop = false;
            // 
            // AudioRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(423, 93);
            this.Controls.Add(this.recordingIcon);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AudioRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioRecorder";
            this.Load += new System.EventHandler(this.AudioRecorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordingIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroButton playButton;
        private MetroFramework.Controls.MetroButton sendButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox recordingIcon;
    }
}