using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BirdUI1;
using flyBird.HotspotAndIP;
using flyBird.Messages;
using flyBird.WinFormUI;

namespace flyBird
{
    public partial class ContactsOnMain : UserControl
    {
        //middlecontroller singleton object
        public MiddleController middleController = MiddleController.getInstance();

        public MainForm mainForm = MainForm.Instance;

        public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();

        #region static instance

        private ContactsOnMain()
        {
            InitializeComponent();
            
       

            setMsgReceivedEvent();
        }

        

        private void setMsgReceivedEvent()
        {
            middleController.MsgReceived += OnMsgTextReceived;
        }

        private void OnMsgTextReceived(object sender, TextMessageArgs e)
        {
            //selecting the required chatDisplay from contact
            ChatDisplay cd = contacts[e.msg.ipToken].chatDisplay;

            cd.addReceivedMessageToUI(e.msg);
        }

        private static ContactsOnMain _instance;

        public static ContactsOnMain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContactsOnMain();
                }

                return _instance;
            }
        }

        #endregion

        private void connectBtn_Click(object sender, EventArgs e)
        {
            string token = connectIpTokenText.Text;
            if (contacts.ContainsKey(token))
                return;

            ////Connecting////////
            middleController.connect(token, "");
            /////////////////////

            //no need this
//            addContact(token);
        }


        private static int userCount;


        public void addContact(string token)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(addContact), token);
                return;
            }
            string name = "User " + userCount++;
            var contact = new Contact(token, name);

            contact.MouseClick += onContactClick;

            contacts.Add(token, contact);

            contactsPanel.Controls.Add(contact);

            contact.select();
            contact.Dock = DockStyle.Top;
        }

        public void removeContact(Contact contact)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Contact>(removeContact), contact);
                return;
            }
            contactsPanel.Controls.Remove(contact);
            mainForm.Container.Controls.Remove(contact.chatDisplay);

            contacts.Remove(contact.token);
            contact.Dispose();
        }

        private Contact previousSelected;


        private Color buttonHoverColor = AppTheme.ButtonHoverColor;
        private Color buttonNormalColor = AppTheme.ButtonNormalColor;

        public void onContactClick(object sender, EventArgs e)
        {
            var con = ((Contact) sender);

            if (previousSelected == null)
            {
            }
            else if (con != previousSelected)
            {
                previousSelected.unselect();
            }


            previousSelected = con;
        }

        private void connectBtn_MouseHover(object sender, EventArgs e)
        {
            connectBtn.BackColor = buttonHoverColor;
        }

        private void connectBtn_MouseLeave(object sender, EventArgs e)
        {
            connectBtn.BackColor = buttonNormalColor;
        }

        private void connectIpTokenText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                connectBtn_Click(sender, e);
            }
        }

        public void removeContactByToken(string token)
        {
            if (contacts.ContainsKey(token))
            {
                removeContact(contacts[token]);
            }
        }


        private void myIpLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}