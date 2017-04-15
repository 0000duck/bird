//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Timers;
//
//namespace flyBird.UI_1
//{
//    public partial class chatApp : Form
//    {
//        private string ipToken = "127.0.0.1";
//
//
//
//        private MiddleController middleController;
//
//        private System.Timers.Timer tmr;
//        public chatApp()
//        {
//            InitializeComponent();
//            middleController = MiddleController.getInstance();
//            regEvents();
//           tmr=new System.Timers.Timer();
//
//            tmr.Interval = 500;
//            tmr.Elapsed += timer_tick;
//
//
//        }
//
//        private void timer_tick(object o,ElapsedEventArgs e)
//        {
//            overallProgressBar.Value = middleController.fileShareController.getOverallProgress();
//        }
//        public void OnConnected(object source, string ip) //from an mc event
//        {
//            setConnectionStatus(ip);
//          
//            tmr.Start();
//
//
//        }
//
//        private void setConnectionStatus(string ip)
//        {
//            if (middleController.serverPart.isServerRunning)
//            {
//                serverLabel.Text += ip;
//
//            }
//            else
//            {
//                clientLabel.Text += ip;
//            }
//        }
//
//        private void OnChatApp_Closing(object o,CancelEventArgs e)
//        {
//            middleController.closeAllSockets();
//        }
//
//        private void regEvents()
//        {
//            middleController.MsgReceived += OnMsgReceived;
//            this.Closing += OnChatApp_Closing;
//
//            middleController.fileShareController.Connected += OnConnected;
//        }
//
//
//        private void connectBtn_Click(object sender, EventArgs e)
//        {
//            middleController.connect(ipText.Text, clientPortText.Text); //should be the token
//        }
//
//        private void textSendBtn_Click(object sender, EventArgs e)
//        {
//            string ip = ipToken; // get the desired receiver
//            middleController.sendText(messageText.Text, ip);
//            addSent(messageText.Text, ip);
//        }
//
//
//        private void OnMsgReceived(object source, TextMessageRecivedEventArgs e)
//        {
//            //Console.WriteLine("msg recieved");
//            addReceived(e.text, e.id);
//        }
//
//        public void addReceived(string msg, string ipToken)
//        {
//            if (InvokeRequired)
//            {
//                Invoke(new Action<string, string>(addReceived), msg, ipToken);
//                return;
//            }
//            chatViewTextBox.Text += ipToken + ": " + msg + "\n";
//            chatViewTextBoxT.Text = ipToken + ": " + msg + "\n";
//        }
//
//
//        public void addSent(string msg, string ipToken)
//        {
//            Console.WriteLine("sending msg");
//
//            if (InvokeRequired)
//            {
//                Invoke(new Action<string, string>(addSent), msg, ipToken);
//                return;
//            }
//            chatViewTextBoxT.Text = ipToken + "(me): " + msg + "\n";
//            chatViewTextBox.Text += ipToken + "(me): " + msg + "\n";
//        }
//
//        private void startServerBtn_Click(object sender, EventArgs e)
//        {
//            middleController.startServer(serverPortText.Text);
//
//        }
//
//        private void fileSendBtn_Click(object sender, EventArgs e)
//        {
//            middleController.fileShareController.chooseAndSendFile();
//
//        }
//    }
//}