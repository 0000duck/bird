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
            this.settingsPic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serverBtn = new MetroFramework.Controls.MetroButton();
            this.menuPic = new System.Windows.Forms.PictureBox();
            this.backPic = new System.Windows.Forms.PictureBox();
            this.container = new MetroFramework.Controls.MetroPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrshIpButton = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.myIpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPic
            // 
            this.settingsPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.settingsPic.Image = ((System.Drawing.Image)(resources.GetObject("settingsPic.Image")));
            this.settingsPic.Location = new System.Drawing.Point(12, 15);
            this.settingsPic.Name = "settingsPic";
            this.settingsPic.Size = new System.Drawing.Size(26, 25);
            this.settingsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsPic.TabIndex = 3;
            this.settingsPic.TabStop = false;
            this.settingsPic.Click += new System.EventHandler(this.settings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.refrshIpButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.myIpLabel);
            this.panel2.Controls.Add(this.serverBtn);
            this.panel2.Controls.Add(this.menuPic);
            this.panel2.Controls.Add(this.backPic);
            this.panel2.Controls.Add(this.settingsPic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 55);
            this.panel2.TabIndex = 4;
            // 
            // serverBtn
            // 
            this.serverBtn.Location = new System.Drawing.Point(248, 20);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(130, 23);
            this.serverBtn.TabIndex = 7;
            this.serverBtn.Text = "Let others connect";
            this.serverBtn.UseSelectable = true;
            this.serverBtn.Click += new System.EventHandler(this.serverBtn_Click_1);
            // 
            // menuPic
            // 
            this.menuPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.menuPic.Image = ((System.Drawing.Image)(resources.GetObject("menuPic.Image")));
            this.menuPic.Location = new System.Drawing.Point(843, 12);
            this.menuPic.Name = "menuPic";
            this.menuPic.Size = new System.Drawing.Size(26, 25);
            this.menuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuPic.TabIndex = 5;
            this.menuPic.TabStop = false;
            this.menuPic.Click += new System.EventHandler(this.menuPic_Click);
            // 
            // backPic
            // 
            this.backPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.backPic.Image = ((System.Drawing.Image)(resources.GetObject("backPic.Image")));
            this.backPic.Location = new System.Drawing.Point(12, 15);
            this.backPic.Name = "backPic";
            this.backPic.Size = new System.Drawing.Size(26, 25);
            this.backPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPic.TabIndex = 4;
            this.backPic.TabStop = false;
            this.backPic.Click += new System.EventHandler(this.backPic_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.Control;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.HorizontalScrollbarBarColor = true;
            this.container.HorizontalScrollbarHighlightOnWheel = false;
            this.container.HorizontalScrollbarSize = 10;
            this.container.Location = new System.Drawing.Point(0, 55);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(873, 545);
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
            // refrshIpButton
            // 
            this.refrshIpButton.BackgroundImage = global::flyBird.Properties.Resources.Refresh;
            this.refrshIpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refrshIpButton.Location = new System.Drawing.Point(184, 20);
            this.refrshIpButton.Name = "refrshIpButton";
            this.refrshIpButton.Size = new System.Drawing.Size(26, 23);
            this.refrshIpButton.TabIndex = 14;
            this.refrshIpButton.UseSelectable = true;
            this.refrshIpButton.Click += new System.EventHandler(this.refrshIpButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "My IP :";
            // 
            // myIpLabel
            // 
            this.myIpLabel.AutoSize = true;
            this.myIpLabel.ForeColor = System.Drawing.Color.White;
            this.myIpLabel.Location = new System.Drawing.Point(99, 24);
            this.myIpLabel.Name = "myIpLabel";
            this.myIpLabel.Size = new System.Drawing.Size(79, 13);
            this.myIpLabel.TabIndex = 12;
            this.myIpLabel.Text = "Not Connected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(873, 600);
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
            ((System.ComponentModel.ISupportInitialize)(this.settingsPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox settingsPic;
        private MetroFramework.Controls.MetroPanel container;
        private System.Windows.Forms.PictureBox backPic;
        private System.Windows.Forms.PictureBox menuPic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MetroFramework.Controls.MetroButton serverBtn;
        private MetroFramework.Controls.MetroButton refrshIpButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label myIpLabel;
    }
}

