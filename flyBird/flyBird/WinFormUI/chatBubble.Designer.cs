namespace flyBird
{
    partial class ChatBubble
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
            this.bubbleTime = new System.Windows.Forms.Label();
            this.bubbleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bubbleTime
            // 
            this.bubbleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleTime.ForeColor = System.Drawing.Color.SkyBlue;
            this.bubbleTime.Location = new System.Drawing.Point(14, 43);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(78, 21);
            this.bubbleTime.TabIndex = 3;
            this.bubbleTime.Text = "Sat 2.53 pm";
            // 
            // bubbleText
            // 
            this.bubbleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bubbleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleText.ForeColor = System.Drawing.Color.White;
            this.bubbleText.Location = new System.Drawing.Point(14, 11);
            this.bubbleText.Name = "bubbleText";
            this.bubbleText.Size = new System.Drawing.Size(321, 32);
            this.bubbleText.TabIndex = 2;
            this.bubbleText.Text = "bla bla bla bla bla bal bla bla bla bla bla bal bla bla bla bla bla bal bla bla b" +
    "la bla bla bal bla bla bla bla bla balbla bla bla bla bla bal";
            // 
            // chatBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.bubbleTime);
            this.Controls.Add(this.bubbleText);
            this.Name = "ChatBubble";
            this.Size = new System.Drawing.Size(353, 66);
            this.Resize += new System.EventHandler(this.chatBubble_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bubbleTime;
        private System.Windows.Forms.Label bubbleText;
    }
}
