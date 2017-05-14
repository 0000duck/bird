namespace flyBird.WinFormUI
{
    partial class AudioMessageBubble
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overallProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.bubbleTime = new System.Windows.Forms.Label();
            this.confirmButton = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseStartToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // pauseStartToolStripMenuItem
            // 
            this.pauseStartToolStripMenuItem.Name = "pauseStartToolStripMenuItem";
            this.pauseStartToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pauseStartToolStripMenuItem.Text = "Pause/Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // overallProgressBar
            // 
            this.overallProgressBar.Location = new System.Drawing.Point(3, 3);
            this.overallProgressBar.Name = "overallProgressBar";
            this.overallProgressBar.Size = new System.Drawing.Size(321, 42);
            this.overallProgressBar.TabIndex = 1;
            // 
            // bubbleTime
            // 
            this.bubbleTime.AutoSize = true;
            this.bubbleTime.Location = new System.Drawing.Point(5, 51);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(35, 13);
            this.bubbleTime.TabIndex = 3;
            this.bubbleTime.Text = "label1";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(330, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(42, 42);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Play";
            this.confirmButton.UseSelectable = true;
            this.confirmButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // AudioMessageBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.bubbleTime);
            this.Controls.Add(this.overallProgressBar);
            this.Name = "AudioMessageBubble";
            this.Size = new System.Drawing.Size(375, 69);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar overallProgressBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pauseStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label bubbleTime;
        private MetroFramework.Controls.MetroButton confirmButton;
    }
}
