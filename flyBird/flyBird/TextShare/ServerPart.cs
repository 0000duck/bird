using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace flyBird
{
    public class ServerPart
    {
        #region staticInstance

        private static ServerPart instance;

        private ServerPart()
        {
        }

        public static ServerPart getInstance()
        {
            if (instance == null)
            {
                instance = new ServerPart();
            }

            return instance;
        }

        #endregion

        public Socket connectionFinder;
        private Thread serverThread;
        //private int serverPort = settings.Default.socketPort;

        public bool isServerRunning { get; private set; }


        public event EventHandler<SocketAddedEventArgs> SocketCreated;


        public void startServer(string port)
        {
            try
            {
                connectionFinder = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                connectionFinder.Bind(new IPEndPoint(0, Int32.Parse(port)));

                connectionFinder.Listen(0);

                accept();
                Console.WriteLine("server starts at port:" + Int32.Parse(port));

                isServerRunning = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void stopServer()
        {
            if (isServerRunning)
            {
                isServerRunning = false;
                try
                {
//                    serverThread.Abort();
                    connectionFinder.Close();
                    connectionFinder = null;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    connectionFinder.Close();
                    connectionFinder = null;
                }
            }
        }

        private void accept()
        {
            serverThread = new Thread(
                () =>
                {
                    while (true)
                    {
                        if (connectionFinder != null)
                        {
                            try
                            {

                                Socket acceptedSocket = connectionFinder.Accept();

                                IPAddress address = (acceptedSocket.RemoteEndPoint as IPEndPoint).Address;

                                string id = IDMaker.getID(address);

                                OnSocketCreated(id, acceptedSocket); //socket created for new client evetn fire
                            }

                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                serverThread.Abort();

                            }
                        }
                        serverThread.Abort();
                    }
                });

            serverThread.Start();
        }

        protected virtual void OnSocketCreated(string idOfSocket, Socket createdSocket) //someone connected to server
        {
            if (SocketCreated != null)
            {
                SocketCreated(this, new SocketAddedEventArgs() {id = idOfSocket, socket = createdSocket});
            }
        }
    }
}