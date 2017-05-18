namespace flyBird
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuPic = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.serverRunningPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myIpLabel = new System.Windows.Forms.Label();
            this.backPic = new System.Windows.Forms.PictureBox();
            this.settingsPic = new System.Windows.Forms.PictureBox();
            this.container = new MetroFramework.Controls.MetroPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serverBtnPic = new System.Windows.Forms.PictureBox();
            this.hotspotBtn = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverRunningPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotspotBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.menuPic);
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Controls.Add(this.userPic);
            this.panel2.Controls.Add(this.serverRunningPic);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.myIpLabel);
            this.panel2.Controls.Add(this.backPic);
            this.panel2.Controls.Add(this.settingsPic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 55);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuPic
            // 
            this.menuPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPic.BackColor = System.Drawing.Color.Transparent;
            this.menuPic.Image = ((System.Drawing.Image)(resources.GetObject("menuPic.Image")));
            this.menuPic.Location = new System.Drawing.Point(830, 13);
            this.menuPic.Name = "menuPic";
            this.menuPic.Size = new System.Drawing.Size(26, 25);
            this.menuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuPic.TabIndex = 5;
            this.menuPic.TabStop = false;
            this.menuPic.Click += new System.EventHandler(this.menuPic_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(654, 16);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(82, 20);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "userName";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // userPic
            // 
            this.userPic.Location = new System.Drawing.Point(611, 9);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(36, 36);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 19;
            this.userPic.TabStop = false;
            this.userPic.Click += new System.EventHandler(this.userPic_Click);
            // 
            // serverRunningPic
            // 
            this.serverRunningPic.Image = global::flyBird.Properties.Resources.chatLeading;
            this.serverRunningPic.Location = new System.Drawing.Point(561, 9);
            this.serverRunningPic.Name = "serverRunningPic";
            this.serverRunningPic.Size = new System.Drawing.Size(36, 36);
            this.serverRunningPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.serverRunningPic.TabIndex = 16;
            this.serverRunningPic.TabStop = false;
            this.serverRunningPic.Click += new System.EventHandler(this.serverRunningPic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "My IP :";
            // 
            // myIpLabel
            // 
            this.myIpLabel.AutoSize = true;
            this.myIpLabel.ForeColor = System.Drawing.Color.White;
            this.myIpLabel.Location = new System.Drawing.Point(97, 20);
            this.myIpLabel.Name = "myIpLabel";
            this.myIpLabel.Size = new System.Drawing.Size(79, 13);
            this.myIpLabel.TabIndex = 12;
            this.myIpLabel.Text = "Not Connected";
            this.myIpLabel.Click += new System.EventHandler(this.myIpLabel_Click);
            // 
            // backPic
            // 
            this.backPic.BackColor = System.Drawing.Color.Transparent;
            this.backPic.Image = ((System.Drawing.Image)(resources.GetObject("backPic.Image")));
            this.backPic.Location = new System.Drawing.Point(12, 20);
            this.backPic.Name = "backPic";
            this.backPic.Size = new System.Drawing.Size(26, 25);
            this.backPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPic.TabIndex = 4;
            this.backPic.TabStop = false;
            this.backPic.Click += new System.EventHandler(this.backPic_Click);
            // 
            // settingsPic
            // 
            this.settingsPic.BackColor = System.Drawing.Color.Transparent;
            this.settingsPic.Image = ((System.Drawing.Image)(resources.GetObject("settingsPic.Image")));
            this.settingsPic.Location = new System.Drawing.Point(12, 20);
            this.settingsPic.Name = "settingsPic";
            this.settingsPic.Size = new System.Drawing.Size(26, 25);
            this.settingsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPic.TabIndex = 3;
            this.settingsPic.TabStop = false;
            this.settingsPic.Click += new System.EventHandler(this.settings_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.Control;
            this.container.HorizontalScrollbarBarColor = true;
            this.container.HorizontalScrollbarHighlightOnWheel = false;
            this.container.HorizontalScrollbarSize = 10;
            this.container.Location = new System.Drawing.Point(55, 55);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(818, 545);
            this.container.TabIndex = 5;
            this.container.VerticalScrollbarBarColor = true;
            this.container.VerticalScrollbarHighlightOnWheel = false;
            this.container.VerticalScrollbarSize = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // serverBtnPic
            // 
            this.serverBtnPic.BackColor = System.Drawing.Color.Transparent;
            this.serverBtnPic.Image = global::flyBird.Properties.Resources.chatLeadOff;
            this.serverBtnPic.Location = new System.Drawing.Point(9, 121);
            this.serverBtnPic.Name = "serverBtnPic";
            this.serverBtnPic.Size = new System.Drawing.Size(40, 40);
            this.serverBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serverBtnPic.TabIndex = 18;
            this.serverBtnPic.TabStop = false;
            this.serverBtnPic.Click += new System.EventHandler(this.serverBtnPic_Click);
            // 
            // hotspotBtn
            // 
            this.hotspotBtn.BackColor = System.Drawing.Color.Transparent;
            this.hotspotBtn.Image = global::flyBird.Properties.Resources.noHotspotWhite;
            this.hotspotBtn.Location = new System.Drawing.Point(9, 180);
            this.hotspotBtn.Name = "hotspotBtn";
            this.hotspotBtn.Size = new System.Drawing.Size(40, 40);
            this.hotspotBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hotspotBtn.TabIndex = 21;
            this.hotspotBtn.TabStop = false;
            this.hotspotBtn.Click += new System.EventHandler(this.hotspotBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(873, 600);
            this.Controls.Add(this.serverBtnPic);
            this.Controls.Add(this.hotspotBtn);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fly Bird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverRunningPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotspotBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox settingsPic;
        private MetroFramework.Controls.MetroPanel container;
        private System.Windows.Forms.PictureBox backPic;
        private System.Windows.Forms.PictureBox menuPic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label myIpLabel;
        private System.Windows.Forms.PictureBox serverRunningPic;
        private System.Windows.Forms.PictureBox serverBtnPic;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.PictureBox hotspotBtn;
    }
}

