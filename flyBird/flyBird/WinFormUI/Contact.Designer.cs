namespace flyBird.WinFormUI
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.contactPanelBackgrount = new System.Windows.Forms.Panel();
            this.tokenText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.contactPic = new System.Windows.Forms.PictureBox();
            this.bottumPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactPanelBackgrount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactPic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactPanelBackgrount
            // 
            this.contactPanelBackgrount.BackColor = System.Drawing.Color.SkyBlue;
            this.contactPanelBackgrount.Controls.Add(this.bottumPanel);
            this.contactPanelBackgrount.Controls.Add(this.tokenText);
            this.contactPanelBackgrount.Controls.Add(this.nameText);
            this.contactPanelBackgrount.Controls.Add(this.contactPic);
            this.contactPanelBackgrount.Location = new System.Drawing.Point(0, 0);
            this.contactPanelBackgrount.Name = "contactPanelBackgrount";
            this.contactPanelBackgrount.Size = new System.Drawing.Size(267, 63);
            this.contactPanelBackgrount.TabIndex = 0;
            this.contactPanelBackgrount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Contact_MouseClick);
            this.contactPanelBackgrount.MouseLeave += new System.EventHandler(this.Contact_MouseLeave);
            this.contactPanelBackgrount.MouseHover += new System.EventHandler(this.Contact_MouseHover);
            // 
            // tokenText
            // 
            this.tokenText.AutoSize = true;
            this.tokenText.Location = new System.Drawing.Point(71, 38);
            this.tokenText.Name = "tokenText";
            this.tokenText.Size = new System.Drawing.Size(34, 13);
            this.tokenText.TabIndex = 4;
            this.tokenText.Text = "token";
            this.tokenText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Contact_MouseClick);
            this.tokenText.MouseLeave += new System.EventHandler(this.Contact_MouseLeave);
            this.tokenText.MouseHover += new System.EventHandler(this.Contact_MouseHover);
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(71, 14);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(48, 18);
            this.nameText.TabIndex = 3;
            this.nameText.Text = "Name";
            this.nameText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Contact_MouseClick);
            this.nameText.MouseHover += new System.EventHandler(this.Contact_MouseHover);
            // 
            // contactPic
            // 
            this.contactPic.Image = ((System.Drawing.Image)(resources.GetObject("contactPic.Image")));
            this.contactPic.Location = new System.Drawing.Point(4, 8);
            this.contactPic.Name = "contactPic";
            this.contactPic.Size = new System.Drawing.Size(53, 50);
            this.contactPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactPic.TabIndex = 0;
            this.contactPic.TabStop = false;
            this.contactPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Contact_MouseClick);
            this.contactPic.MouseLeave += new System.EventHandler(this.Contact_MouseLeave);
            this.contactPic.MouseHover += new System.EventHandler(this.Contact_MouseHover);
            // 
            // bottumPanel
            // 
            this.bottumPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(181)))));
            this.bottumPanel.Location = new System.Drawing.Point(225, 0);
            this.bottumPanel.Name = "bottumPanel";
            this.bottumPanel.Size = new System.Drawing.Size(42, 63);
            this.bottumPanel.TabIndex = 1;
            this.bottumPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Contact_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 48);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.contactPanelBackgrount);
            this.Name = "Contact";
            this.Size = new System.Drawing.Size(267, 66);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Contact_MouseClick);
            this.contactPanelBackgrount.ResumeLayout(false);
            this.contactPanelBackgrount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactPic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contactPanelBackgrount;
        private System.Windows.Forms.PictureBox contactPic;
        private System.Windows.Forms.Label tokenText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Panel bottumPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
    }
}
