using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BirdUI1;
using flyBird.Contacts;
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

        public Dictionary<string, ContactTab> contacts = new Dictionary<string, ContactTab>();

        private static ContactsOnMain _instance;

        #region static instance

        private ContactsOnMain()
        {
            InitializeComponent();

            setEvents();
        }


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

        private void setEvents()
        {
            middleController.MsgReceived += OnMsgTextReceived;
            ControlHandler.getInstance().ContactUpdate += OnContactUpdate;
           
        }

        private void OnContactUpdate(object sender, ControlCommandOccuredEventArgs e)
        {
            Contact cnt = ContactBuilder.getContactFromReceivedData(e.data);
            
            Console.WriteLine("contact update event");
            Console.WriteLine("id"+e.id+"\nmac: " + cnt.mac + "\nname: " + cnt.name + "\ncurrent ip: " + cnt.currentIp);

            if (contacts.ContainsKey(e.id))
            {
                contacts[e.id].updateContact(cnt);
            }
            else
            {
                Console.WriteLine("Contact id not found for updating..  id: " + e.id);
                Console.Write("contacts now have are: ");

                foreach (var cn in contacts)
                {
                    Console.Write(cn.Key+",");
                }
                Console.WriteLine();
            }
           
//            Console.WriteLine("current ip of update comming contact: "+contact.currentIp);
//            contacts[contact.currentIp].updateContact(contact);
        }

        private void OnMsgTextReceived(object sender, TextMessageArgs e)
        {
            //selecting the required chatDisplay from contact
            ChatDisplay cd = contacts[e.msg.ipToken].chatDisplay;

            cd.addReceivedMessageToUI(e.msg);
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
            var contactTab = new ContactTab(token, name);

            contactTab.MouseClick += onContactClick;

            contacts.Add(token, contactTab);

            contactsPanel.Controls.Add(contactTab);

            contactTab.select();
            contactTab.Dock = DockStyle.Top;

        }

        public void removeContact(ContactTab contact)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ContactTab>(removeContact), contact);
                return;
            }
            contactsPanel.Controls.Remove(contact);
            mainForm.Container.Controls.Remove(contact.chatDisplay);

            contacts.Remove(contact.token);
            contact.Dispose();
        }

        private ContactTab previousSelected;


        private Color buttonHoverColor = AppTheme.ButtonHoverColor;
        private Color buttonNormalColor = AppTheme.ButtonNormalColor;

        public void onContactClick(object sender, EventArgs e)
        {
            var con = ((ContactTab) sender);

            if (previousSelected == null)
            {
            }
            else if (con != previousSelected)
            {
                previousSelected.unselect();
            }


            previousSelected = con;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new NewChat(this,middleController).Show();
        }
    }
}