using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using flyBird.Messages;
using flyBird.TextShare;

namespace flyBird
{
    public class TextMessageArgs : EventArgs
    {
        public TextMessage msg { set; get; }
    }

    public class MiddleController : Form
    {
        #region staticInstance

        private static MiddleController instance;


        private MiddleController()
        {
            initComponents();
        }

        public static MiddleController getInstance()
        {
            if (instance == null)
            {
                instance = new MiddleController();
            }

            return instance;
        }

        #endregion

        public event EventHandler<TextMessageArgs> MsgReceived;

        private Reciever reciever;
        private Sender sender;
        private SocketStore socketStore;
        public ServerPart serverPart;
        private ClientPart clientPart;
        private Encoder encoder;
        private ControlHandler controlHandler;


        public FileShareMiddleController fileShareController;
        string filePort = settings.Default.fileSharePort.ToString();
        string commonPort = settings.Default.socketPort.ToString();


        public MainForm uiMainForm;

        public void initComponents()
        {
            //instances
            serverPart = ServerPart.getInstance();
            clientPart = ClientPart.getInstance();
            socketStore = SocketStore.getInstance();
            reciever = new Reciever();
            sender = Sender.getInstance();
            encoder = Encoder.getInstance();
            controlHandler = ControlHandler.getInstance();


            fileShareController = new FileShareMiddleController();


            //events registering
            registerEvnts();

            //starting
            //serverPart.startServer();
        }

        private void registerEvnts()
        {
            serverPart.SocketCreated += socketStore.OnSocketCreated;
            serverPart.SocketCreated += OnServerAccepted;

            clientPart.SocketConnected += socketStore.OnSocketCreated;
            clientPart.SocketConnected += OnClientAccepted;

            socketStore.SocketAdded += reciever.OnNewSoketAdded;

            encoder.ControlCommandOccured += controlHandler.OnControlOccured;

            reciever.TextMessageReceived += OnTextMsgReceived;

            fileShareController.DisconnectedTransferClient += OnDisconnected;
        }

        private void OnDisconnected(object o, EventArgs e)
        {
        }

        private void OnClientAccepted(object o, SocketAddedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, SocketAddedEventArgs>(OnClientAccepted), o, e);
                return;
            }
            uiMainForm.contactsPannel.addContact(e.id);
        }

        private void OnServerAccepted(object o, SocketAddedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, SocketAddedEventArgs>(OnServerAccepted), o, e);
                return;
            }
            uiMainForm.contactsPannel.addContact(e.id);
        }


        public void connect(string ipToken, string port)
        {
//            //using common port
//            clientPart.connect(getIpString(ipToken), commonPort);
//
//            fileShareController.connect(ipToken, filePort); //fs 
            
            //using common port
            clientPart.connect(getIpString(ipToken),"3661");

            fileShareController.connect(ipToken, "3662"); //fs
        }

        public void disconnect(string ipToken)
        {
            closeSocket(ipToken);
            fileShareController.disconnect();
        }


        public void disconnectHandle(string token)
        {
            disconnect(token);
            ContactsOnMain.Instance.removeContactByToken(token);
        }

        private string getIpString(string ipToken)
        {
            return ipToken; //should implement a method to minimize it.
        }

        public void sendText(string text, string ipToken_)
        {
            try
            {
                //sending
                sender.sendMessage(text, socketStore.getSocket(ipToken_));


                var textMsg = new TextMessage() {text = text, ipToken = ipToken_};

                //saving
                //
            }
            catch (Exception e)
            {
                disconnectHandle(ipToken_);
                disconnect(ipToken_);
            }
        }

        private void OnTextMsgReceived(object o, TextMessageRecivedEventArgs e)
        {
            if (MsgReceived != null)
            {
                var textMsg = new TextMessage() {text = e.text, ipToken = e.id};

                //saving
                //

                //to ui
                MsgReceived(this, new TextMessageArgs() {msg = textMsg});
            }
        }

        public void startServer(string port)
        {
            //using common port
            try
            {
//                serverPart.startServer(commonPort);
                serverPart.startServer("3661");

//                fileShareController.startServer(filePort); //fs
                fileShareController.startServer("3662"); //fs
            }
            catch (System.Net.Sockets.SocketException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public void stopServer()
        {
            serverPart.stopServer();
            fileShareController.stopServer();
        }

        private void closeSocket(string ipToken)
        {
            if (socketStore.SocketDic.ContainsKey(ipToken))
            {
                socketStore.SocketDic[ipToken].Close();
                socketStore.SocketDic.Remove(ipToken);
            }
        }

        public void closeAllSockets()
        {
            foreach (var socketD in socketStore.SocketDic)
            {
                socketD.Value.Close();
                socketStore.SocketDic.Remove(socketD.Key);
            }

//            serverPart.connectionFinder.Close();
        }
    }
}