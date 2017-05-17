namespace flyBird.WinFormUI
{
    partial class NewChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewChat));
            this.connectIpTokenText = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectIpTokenText
            // 
            // 
            // 
            // 
            this.connectIpTokenText.CustomButton.Image = null;
            this.connectIpTokenText.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.connectIpTokenText.CustomButton.Name = "";
            this.connectIpTokenText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.connectIpTokenText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.connectIpTokenText.CustomButton.TabIndex = 1;
            this.connectIpTokenText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.connectIpTokenText.CustomButton.UseSelectable = true;
            this.connectIpTokenText.CustomButton.Visible = false;
            this.connectIpTokenText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.connectIpTokenText.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.connectIpTokenText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connectIpTokenText.Lines = new string[] {
        "127.0.0.1"};
            this.connectIpTokenText.Location = new System.Drawing.Point(69, 29);
            this.connectIpTokenText.MaxLength = 32767;
            this.connectIpTokenText.Name = "connectIpTokenText";
            this.connectIpTokenText.PasswordChar = '\0';
            this.connectIpTokenText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.connectIpTokenText.SelectedText = "";
            this.connectIpTokenText.SelectionLength = 0;
            this.connectIpTokenText.SelectionStart = 0;
            this.connectIpTokenText.ShortcutsEnabled = true;
            this.connectIpTokenText.Size = new System.Drawing.Size(97, 23);
            this.connectIpTokenText.TabIndex = 12;
            this.connectIpTokenText.Text = "127.0.0.1";
            this.connectIpTokenText.UseSelectable = true;
            this.connectIpTokenText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.connectIpTokenText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.connectIpTokenText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.connectIpTokenText_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::flyBird.Properties.Resources.connectBl;
            this.pictureBox1.Location = new System.Drawing.Point(158, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(337, 80);
            this.Controls.Add(this.connectIpTokenText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "NewChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewChat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox connectIpTokenText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}