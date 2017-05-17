using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BirdUI1;
using flyBird.Contacts;
using flyBird.HotspotAndIP;
using flyBird.WinFormUI;


namespace flyBird
{
    public partial class MainForm : Form
    {
        private Contact myProfile;
        private MainForm()
        {
            InitializeComponent();
            serverRunningPic.Visible = false;
            setDependentObjects();
            
            setMyIp();
            myIpLabel.Focus();


            myProfile = ContactsStore.getInstance().getMyProfile();
            setMyProfileDetails();

        }

        public void setMyProfileDetails()
        {
            myProfile = ContactsStore.getInstance().getMyProfile();
            if (File.Exists(myProfile.displayProfile))
            {
                userPic.Image = Image.FromFile(myProfile.displayProfile);
            }
            
            userNameLabel.Text = myProfile.name;

            userNameLabel.Left= 795 - userNameLabel.Size.Width;
            userPic.Left = 795 - userNameLabel.Size.Width - 36-7;

            serverRunningPic.Left = userPic.Left - (36 + 14);


        }

        #region static instance

        private static MainForm _instance;

        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainForm();
                }

                return _instance;
            }
        }

        #endregion
        public MetroFramework.Controls.MetroPanel Container
        {
            get { return container; }
            set { container = value; }
        }

        private void setDependentObjects()
        {

            middleController.uiMainForm = this;
            ////Automatically start server////////
            //// 
            ////cannot test in one pc
            ////
//            middleController.startServer("");
            ///////////////////////////////////
        }


        //middlecontroller singleton object
        public MiddleController middleController=MiddleController.getInstance();

        public ContactsOnMain contactsPannel;
        public ChatDisplay currentChatDisplay;
        private UserSettings settings;
        public List<ChatDisplay> chatDisplays = new List<ChatDisplay>();


        private Color serverBtnNormalColor = AppTheme.ServerButtonNormalColor;
        private Color serverBtnStopColor = AppTheme.ServerButtonStopColor;



        private void mainForm_Load(object sender, EventArgs e)
        {
            backPic.Visible = false;
            _instance = this;
            settings = new UserSettings(this);


            contactsPannel = ContactsOnMain.Instance;
            contactsPannel.mainForm = this;


            container.Controls.Add(contactsPannel);
            contactsPannel.Dock = DockStyle.Left;


        }


        private bool hasSettingsAdded = false;

        public void backPic_Click(object sender, EventArgs e)
        {
            if (hasSettingsAdded)
            {
                container.Controls.Remove(settings);
            }
            container.Controls.Add(contactsPannel);
            contactsPannel.Dock = DockStyle.Left;

            addChatDisplayAndBrigFront(currentChatDisplay);

            backPic.Visible = false;
            settingsPic.Visible = true;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            hasSettingsAdded = true;

            container.Controls.Remove(contactsPannel);
            container.Controls.Remove(currentChatDisplay);

            container.Controls.Add(settings);


            settingsPic.Visible = false;

            backPic.Visible = true;
        }


        public void addChatDisplayAndBrigFront(ChatDisplay cd)
        {
            if (cd != null)
            {
                container.Controls.Remove(currentChatDisplay);
                container.Controls.Add(cd);


                cd.Dock = DockStyle.Right;
                currentChatDisplay = cd;
            }
        }

        private void menuPic_Click(object sender, EventArgs e)
        {
            new ContextMenuStrip().Show(menuPic, new Point(0, menuPic.Height));
        }


        //form events

        #region Form behaviours

        private void minimizePic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizePic_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// Dragable tab for form
        private Point MouseDownLocation;


        private void topTab_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void topTab_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Y > 0)
                {
                    WindowState = FormWindowState.Normal;
                }
            }

            if (WindowState == FormWindowState.Normal && e.Button == System.Windows.Forms.MouseButtons.Left &&
                this.Top <= 0)
            {
                WindowState = FormWindowState.Maximized;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            middleController.closeAllSockets();
            Environment.Exit(0);
        }

        private void clearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }





        private void refrshIpButton_Click(object sender, EventArgs e)
        {
            setMyIp();
        }

        private void setMyIp()
        {
            myIpLabel.Text = IpDetails.getInstance().getMyLocalIp();
        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            if (middleController.serverPart.isServerRunning)
            {

                //stop server
                middleController.stopServer();

                serverRunningPic.Visible = false;
            }
            else
            {
                //start server
                middleController.startServer("");
                serverRunningPic.Visible = true;
            }
        }

        private void myIpLabel_Click(object sender, EventArgs e)
        {
            setMyIp();
        }

        private void serverBtnPic_Click(object sender, EventArgs e)
        {
            if (middleController.serverPart.isServerRunning)
            {

                //stop server
                middleController.stopServer();

                serverRunningPic.Visible = false;

                serverBtnPic.Image = Properties.Resources.chatLeadOff;
            }
            else
            {
                //start server
                middleController.startServer("");
                serverRunningPic.Visible = true;
                serverBtnPic.Image = Properties.Resources.chatLeadOnG;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            settings_Click(sender,e);
        }

        private void userPic_Click(object sender, EventArgs e)
        {
            settings_Click(sender, e);
        }

        private bool hotspotRunning;
        private void hotspotBtn_Click(object sender, EventArgs e)
        {
            if (hotspotRunning)
            {
                //stop now
                Hotspot.getInstance().stopHotspot();
                hotspotBtn.Image = Properties.Resources.noHotspotWhite;
                hotspotRunning = false;

            }
            else
            {
                //start now
                Hotspot.getInstance().createHotspot("name","password");
                hotspotBtn.Image = Properties.Resources.yesHotspotWhite;
                hotspotRunning = true;
            }
        }

        private void serverRunningPic_Click(object sender, EventArgs e)
        {

        }

        /// Dragable tab for form

        #endregion

        //end from events
    }
}