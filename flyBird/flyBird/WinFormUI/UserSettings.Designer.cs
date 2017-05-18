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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.savehotspotBtn = new MetroFramework.Controls.MetroButton();
            this.hotspotPasswordText = new MetroFramework.Controls.MetroTextBox();
            this.hotspotNameText = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.saveEncryptionBtn = new MetroFramework.Controls.MetroButton();
            this.encryptionKeyText = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
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
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
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
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.savehotspotBtn);
            this.metroTabPage2.Controls.Add(this.hotspotPasswordText);
            this.metroTabPage2.Controls.Add(this.hotspotNameText);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(763, 402);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Hotspot Settings    ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(236, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Hotspot password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(236, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Hotspot name";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // savehotspotBtn
            // 
            this.savehotspotBtn.Location = new System.Drawing.Point(561, 352);
            this.savehotspotBtn.Name = "savehotspotBtn";
            this.savehotspotBtn.Size = new System.Drawing.Size(199, 47);
            this.savehotspotBtn.TabIndex = 7;
            this.savehotspotBtn.Text = "Save Changes";
            this.savehotspotBtn.UseSelectable = true;
            this.savehotspotBtn.Click += new System.EventHandler(this.savehotspotBtn_Click);
            // 
            // hotspotPasswordText
            // 
            // 
            // 
            // 
            this.hotspotPasswordText.CustomButton.Image = null;
            this.hotspotPasswordText.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.hotspotPasswordText.CustomButton.Name = "";
            this.hotspotPasswordText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hotspotPasswordText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotspotPasswordText.CustomButton.TabIndex = 1;
            this.hotspotPasswordText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotspotPasswordText.CustomButton.UseSelectable = true;
            this.hotspotPasswordText.CustomButton.Visible = false;
            this.hotspotPasswordText.Lines = new string[0];
            this.hotspotPasswordText.Location = new System.Drawing.Point(236, 168);
            this.hotspotPasswordText.MaxLength = 32767;
            this.hotspotPasswordText.Name = "hotspotPasswordText";
            this.hotspotPasswordText.PasswordChar = '\0';
            this.hotspotPasswordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotspotPasswordText.SelectedText = "";
            this.hotspotPasswordText.SelectionLength = 0;
            this.hotspotPasswordText.SelectionStart = 0;
            this.hotspotPasswordText.ShortcutsEnabled = true;
            this.hotspotPasswordText.Size = new System.Drawing.Size(203, 23);
            this.hotspotPasswordText.TabIndex = 3;
            this.hotspotPasswordText.UseSelectable = true;
            this.hotspotPasswordText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotspotPasswordText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // hotspotNameText
            // 
            // 
            // 
            // 
            this.hotspotNameText.CustomButton.Image = null;
            this.hotspotNameText.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.hotspotNameText.CustomButton.Name = "";
            this.hotspotNameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hotspotNameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hotspotNameText.CustomButton.TabIndex = 1;
            this.hotspotNameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hotspotNameText.CustomButton.UseSelectable = true;
            this.hotspotNameText.CustomButton.Visible = false;
            this.hotspotNameText.Lines = new string[0];
            this.hotspotNameText.Location = new System.Drawing.Point(236, 90);
            this.hotspotNameText.MaxLength = 32767;
            this.hotspotNameText.Name = "hotspotNameText";
            this.hotspotNameText.PasswordChar = '\0';
            this.hotspotNameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotspotNameText.SelectedText = "";
            this.hotspotNameText.SelectionLength = 0;
            this.hotspotNameText.SelectionStart = 0;
            this.hotspotNameText.ShortcutsEnabled = true;
            this.hotspotNameText.Size = new System.Drawing.Size(203, 23);
            this.hotspotNameText.TabIndex = 2;
            this.hotspotNameText.UseSelectable = true;
            this.hotspotNameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hotspotNameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.saveEncryptionBtn);
            this.metroTabPage3.Controls.Add(this.encryptionKeyText);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(763, 402);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Text = "Encryption            ";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(119, 36);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Encryption key";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // saveEncryptionBtn
            // 
            this.saveEncryptionBtn.Location = new System.Drawing.Point(444, 320);
            this.saveEncryptionBtn.Name = "saveEncryptionBtn";
            this.saveEncryptionBtn.Size = new System.Drawing.Size(199, 47);
            this.saveEncryptionBtn.TabIndex = 10;
            this.saveEncryptionBtn.Text = "Save Changes";
            this.saveEncryptionBtn.UseSelectable = true;
            this.saveEncryptionBtn.Click += new System.EventHandler(this.saveKey_Click);
            // 
            // encryptionKeyText
            // 
            // 
            // 
            // 
            this.encryptionKeyText.CustomButton.Image = null;
            this.encryptionKeyText.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.encryptionKeyText.CustomButton.Name = "";
            this.encryptionKeyText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.encryptionKeyText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.encryptionKeyText.CustomButton.TabIndex = 1;
            this.encryptionKeyText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.encryptionKeyText.CustomButton.UseSelectable = true;
            this.encryptionKeyText.CustomButton.Visible = false;
            this.encryptionKeyText.Lines = new string[0];
            this.encryptionKeyText.Location = new System.Drawing.Point(119, 58);
            this.encryptionKeyText.MaxLength = 32767;
            this.encryptionKeyText.Name = "encryptionKeyText";
            this.encryptionKeyText.PasswordChar = '\0';
            this.encryptionKeyText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.encryptionKeyText.SelectedText = "";
            this.encryptionKeyText.SelectionLength = 0;
            this.encryptionKeyText.SelectionStart = 0;
            this.encryptionKeyText.ShortcutsEnabled = true;
            this.encryptionKeyText.Size = new System.Drawing.Size(203, 23);
            this.encryptionKeyText.TabIndex = 9;
            this.encryptionKeyText.UseSelectable = true;
            this.encryptionKeyText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.encryptionKeyText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.encryptionKeyText.Click += new System.EventHandler(this.metroTextBox1_Click);
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
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton savehotspotBtn;
        private MetroFramework.Controls.MetroTextBox hotspotPasswordText;
        private MetroFramework.Controls.MetroTextBox hotspotNameText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton saveEncryptionBtn;
        private MetroFramework.Controls.MetroTextBox encryptionKeyText;
    }
}
