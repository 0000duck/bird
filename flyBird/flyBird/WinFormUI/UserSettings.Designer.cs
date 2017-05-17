namespace flyBird.WinFormUI
{
    partial class UserSettings
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.saveChangesBtn = new MetroFramework.Controls.MetroButton();
            this.choosePicBtn = new MetroFramework.Controls.MetroButton();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(771, 444);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.nameText);
            this.metroTabPage1.Controls.Add(this.saveChangesBtn);
            this.metroTabPage1.Controls.Add(this.choosePicBtn);
            this.metroTabPage1.Controls.Add(this.userPicture);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(763, 402);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Profile          ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(388, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Name";
            // 
            // nameText
            // 
            // 
            // 
            // 
            this.nameText.CustomButton.Image = null;
            this.nameText.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.nameText.CustomButton.Name = "";
            this.nameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameText.CustomButton.TabIndex = 1;
            this.nameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameText.CustomButton.UseSelectable = true;
            this.nameText.CustomButton.Visible = false;
            this.nameText.Lines = new string[0];
            this.nameText.Location = new System.Drawing.Point(388, 58);
            this.nameText.MaxLength = 32767;
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameText.SelectedText = "";
            this.nameText.SelectionLength = 0;
            this.nameText.SelectionStart = 0;
            this.nameText.ShortcutsEnabled = true;
            this.nameText.Size = new System.Drawing.Size(201, 23);
            this.nameText.TabIndex = 5;
            this.nameText.UseSelectable = true;
            this.nameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameText_KeyDown);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(531, 355);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(199, 47);
            this.saveChangesBtn.TabIndex = 4;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseSelectable = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click_1);
            // 
            // choosePicBtn
            // 
            this.choosePicBtn.Location = new System.Drawing.Point(76, 206);
            this.choosePicBtn.Name = "choosePicBtn";
            this.choosePicBtn.Size = new System.Drawing.Size(199, 23);
            this.choosePicBtn.TabIndex = 3;
            this.choosePicBtn.Text = "ChoosePicBtn";
            this.choosePicBtn.UseSelectable = true;
            this.choosePicBtn.Click += new System.EventHandler(this.choosePicBtn_Click);
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(76, 21);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(199, 163);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 2;
            this.userPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UserSettings";
            this.Size = new System.Drawing.Size(818, 545);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroButton saveChangesBtn;
        private MetroFramework.Controls.MetroButton choosePicBtn;
        private System.Windows.Forms.PictureBox userPicture;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
