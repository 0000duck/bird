using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flyBird.WinFormUI
{
    public partial class NewChat : Form
    {
        public NewChat(ContactsOnMain com,MiddleController mc)
        {
            InitializeComponent();
            contactsOnMain = com;
            middleController = mc;
        }

        private ContactsOnMain contactsOnMain;

        private MiddleController middleController;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string token = connectIpTokenText.Text;
            if (contactsOnMain.contacts.ContainsKey(token))
                return;

            ////Connecting////////
            middleController.connect(token, "");
            this.Dispose();
        }

        private void connectIpTokenText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                pictureBox1_Click(sender, e);
            }
        }
    }
}
