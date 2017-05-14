using flyBird;

namespace BirdUI1
{
    partial class ChatDisplay
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.userTokenText = new System.Windows.Forms.Label();
            this.refPanel2 = new System.Windows.Forms.Panel();
            this.refPanel1 = new System.Windows.Forms.Panel();
            this.workSpace = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.recordBtn = new System.Windows.Forms.PictureBox();
            this.sendFileBtn = new System.Windows.Forms.PictureBox();
            this.sendBtn = new System.Windows.Forms.PictureBox();
            this.sendingTextBox = new MetroFramework.Controls.MetroTextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendFileBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.userTokenText);
            this.panel2.Controls.Add(this.refPanel2);
            this.panel2.Controls.Add(this.refPanel1);
            this.panel2.Controls.Add(this.workSpace);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 459);
            this.panel2.TabIndex = 1;
            // 
            // userTokenText
            // 
            this.userTokenText.AutoSize = true;
            this.userTokenText.Location = new System.Drawing.Point(559, 0);
            this.userTokenText.Name = "userTokenText";
            this.userTokenText.Size = new System.Drawing.Size(34, 13);
            this.userTokenText.TabIndex = 9;
            this.userTokenText.Text = "token";
            // 
            // refPanel2
            // 
            this.refPanel2.Enabled = false;
            this.refPanel2.Location = new System.Drawing.Point(15, 13);
            this.refPanel2.Name = "refPanel2";
            this.refPanel2.Size = new System.Drawing.Size(375, 55);
            this.refPanel2.TabIndex = 8;
            // 
            // refPanel1
            // 
            this.refPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refPanel1.Enabled = false;
            this.refPanel1.Location = new System.Drawing.Point(240, 13);
            this.refPanel1.Name = "refPanel1";
            this.refPanel1.Size = new System.Drawing.Size(375, 55);
            this.refPanel1.TabIndex = 7;
            // 
            // workSpace
            // 
            this.workSpace.BackColor = System.Drawing.Color.White;
            this.workSpace.Location = new System.Drawing.Point(93, 353);
            this.workSpace.Name = "workSpace";
            this.workSpace.Size = new System.Drawing.Size(200, 100);
            this.workSpace.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.recordBtn);
            this.panel3.Controls.Add(this.sendFileBtn);
            this.panel3.Controls.Add(this.sendBtn);
            this.panel3.Controls.Add(this.sendingTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 66);
            this.panel3.TabIndex = 0;
            // 
            // recordBtn
            // 
            this.recordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.recordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.recordBtn.Image = global::flyBird.Properties.Resources.recordB;
            this.recordBtn.Location = new System.Drawing.Point(15, 6);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(45, 50);
            this.recordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recordBtn.TabIndex = 3;
            this.recordBtn.TabStop = false;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            this.recordBtn.MouseLeave += new System.EventHandler(this.BtnHover_Left);
            this.recordBtn.MouseHover += new System.EventHandler(this.BtnHover);
            // 
            // sendFileBtn
            // 
            this.sendFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendFileBtn.Image = global::flyBird.Properties.Resources.addFileB;
            this.sendFileBtn.Location = new System.Drawing.Point(66, 6);
            this.sendFileBtn.Name = "sendFileBtn";
            this.sendFileBtn.Size = new System.Drawing.Size(45, 50);
            this.sendFileBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendFileBtn.TabIndex = 2;
            this.sendFileBtn.TabStop = false;
            this.sendFileBtn.Click += new System.EventHandler(this.sendFileBtn_Click);
            this.sendFileBtn.MouseLeave += new System.EventHandler(this.BtnHover_Left);
            this.sendFileBtn.MouseHover += new System.EventHandler(this.BtnHover);
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Image = global::flyBird.Properties.Resources.sendB;
            this.sendBtn.Location = new System.Drawing.Point(574, 9);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(48, 48);
            this.sendBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendBtn.TabIndex = 1;
            this.sendBtn.TabStop = false;
            this.sendBtn.Click += new System.EventHandler(this.sendPicButton_Click);
            this.sendBtn.MouseLeave += new System.EventHandler(this.BtnHover_Left);
            this.sendBtn.MouseHover += new System.EventHandler(this.BtnHover);
            // 
            // sendingTextBox
            // 
            this.sendingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.sendingTextBox.CustomButton.Image = null;
            this.sendingTextBox.CustomButton.Location = new System.Drawing.Point(386, 2);
            this.sendingTextBox.CustomButton.Name = "";
            this.sendingTextBox.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.sendingTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sendingTextBox.CustomButton.TabIndex = 1;
            this.sendingTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sendingTextBox.CustomButton.UseSelectable = true;
            this.sendingTextBox.CustomButton.Visible = false;
            this.sendingTextBox.Lines = new string[0];
            this.sendingTextBox.Location = new System.Drawing.Point(117, 3);
            this.sendingTextBox.MaxLength = 32767;
            this.sendingTextBox.Multiline = true;
            this.sendingTextBox.Name = "sendingTextBox";
            this.sendingTextBox.PasswordChar = '\0';
            this.sendingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sendingTextBox.SelectedText = "";
            this.sendingTextBox.SelectionLength = 0;
            this.sendingTextBox.SelectionStart = 0;
            this.sendingTextBox.ShortcutsEnabled = true;
            this.sendingTextBox.Size = new System.Drawing.Size(444, 60);
            this.sendingTextBox.TabIndex = 0;
            this.sendingTextBox.UseSelectable = true;
            this.sendingTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sendingTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.sendingTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendingTextBox_KeyDown);
            // 
            // ChatDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "ChatDisplay";
            this.Size = new System.Drawing.Size(635, 525);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendFileBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox sendingTextBox;
        private System.Windows.Forms.Panel workSpace;
        private System.Windows.Forms.Panel refPanel2;
        private System.Windows.Forms.Panel refPanel1;
        private System.Windows.Forms.Label userTokenText;
        private System.Windows.Forms.PictureBox recordBtn;
        private System.Windows.Forms.PictureBox sendFileBtn;
        private System.Windows.Forms.PictureBox sendBtn;
    }
}
