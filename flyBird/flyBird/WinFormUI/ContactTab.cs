using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirdUI1;

namespace flyBird.WinFormUI
{
    public delegate void ContactUpdateEventHandler(Contact contact);

    public delegate void ContactPicUpdateEventHandler(string path);

    public partial class ContactTab : UserControl
    {
        public string token;
        public ChatDisplay chatDisplay;

        private MainForm mainForm = MainForm.Instance;
        private ContactsOnMain contactsPanel = ContactsOnMain.Instance;

        private Color hoverColor = AppTheme.contactHoverColor;
        private Color normalColor = AppTheme.contactNormalColor;

        private Color bottumSelectColor = AppTheme.contactSelectedSideColor;

        private Color bottumColor = AppTheme.contactNormalSideColor;

        private Color selctedColor = AppTheme.contactSelectedColor;

        public bool selected = false;

        private string mac;


        public ContactTab(string token)
        {
            InitializeComponent();
            tokenText.Text = token;
        }

        public void updateContact(Contact contact)
        {
            if (InvokeRequired)
            {
                Invoke(new ContactUpdateEventHandler(updateContact), contact);
                return;
            }
            this.mac = contact.mac;
            this.nameText.Text = contact.name;
            this.tokenText.Text = contact.currentIp;
        }

        public void updateContactPic(string path)
        {
            if (InvokeRequired)
            {
                Invoke(new ContactPicUpdateEventHandler(updateContactPic), path);
                return;
            }
            if (File.Exists(path))
            {
                contactPic.Image = Image.FromFile(path);
            }
        }

        public ContactTab(string token, string name)
        {
            InitializeComponent();
            nameText.Text = name;
            tokenText.Text = token;
            chatDisplay = new ChatDisplay(token, MiddleController.getInstance().fileShareController);

            //add previous msges or add previous chat display

            this.token = token;
        }


        public void select()
        {
            selected = true;
            contactPanelBackgrount.BackColor = selctedColor;
            bottumPanel.BackColor = bottumSelectColor;

            mainForm.addChatDisplayAndBrigFront(chatDisplay);
            ContactsOnMain.Instance.onContactClick(this, EventArgs.Empty);
        }

        public void unselect()
        {
            selected = false;
            contactPanelBackgrount.BackColor = normalColor;
            bottumPanel.BackColor = bottumColor;
        }

        private void Contact_MouseClick(object sender, MouseEventArgs e)
        {
            select();
        }

        private void Contact_MouseHover(object sender, EventArgs e)
        {
            if (!selected)
                contactPanelBackgrount.BackColor = hoverColor;
        }

        private void Contact_MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
                contactPanelBackgrount.BackColor = normalColor;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog chat display

            //disconnect
            contactsPanel.removeContact((ContactTab) this);

            MiddleController.getInstance().disconnect(token);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //view contact info
        }
    }
}