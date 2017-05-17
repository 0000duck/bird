namespace flyBird
{
    partial class ContactsOnMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.contactsPanel = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.contactsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.contactsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 552);
            this.panel1.TabIndex = 0;
            // 
            // contactsPanel
            // 
            this.contactsPanel.AutoScroll = true;
            this.contactsPanel.Controls.Add(this.pictureBox2);
            this.contactsPanel.HorizontalScrollbar = true;
            this.contactsPanel.HorizontalScrollbarBarColor = true;
            this.contactsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.contactsPanel.HorizontalScrollbarSize = 10;
            this.contactsPanel.Location = new System.Drawing.Point(0, 0);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(226, 552);
            this.contactsPanel.TabIndex = 5;
            this.contactsPanel.VerticalScrollbar = true;
            this.contactsPanel.VerticalScrollbarBarColor = true;
            this.contactsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.contactsPanel.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::flyBird.Properties.Resources.newChatRedd;
            this.pictureBox2.Location = new System.Drawing.Point(174, 467);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ContactsOnMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ContactsOnMain";
            this.Size = new System.Drawing.Size(227, 552);
            this.panel1.ResumeLayout(false);
            this.contactsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel contactsPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
