using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flyBird
{
    class ClientPart
    {
        #region staticInstance

        private static ClientPart instance;

        private ClientPart()
        {

        }

        public static ClientPart getInstance()
        {
            if (instance == null)
            {
                instance = new ClientPart();
            }

            return instance;
        }

        #endregion
        public event EventHandler<SocketAddedEventArgs> SocketConnected;

        private Socket connectingSocket;

        public void connect(string token,string port)
        {
            
                connectingSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint endPoint = getIpEndfromToken(token,Int32.Parse(port));
            try
            {
                connectingSocket.Connect(endPoint);

                OnsocketConnected(endPoint);
            }
            catch (Exception e)
            {

                connectingSocket.Close();
            }
           

            //listen();
            
        }

        protected virtual void OnsocketConnected(IPEndPoint endPoint)
        {
            if (SocketConnected!=null)
            {
                string idOfServer = IDMaker.getID(endPoint.Address);

                SocketConnected(this, new SocketAddedEventArgs(){id = idOfServer,socket = connectingSocket});

            }
        }

        public string getTokenFromIp(string ip)
        {
            return null;
        }

        public IPEndPoint getIpEndfromToken(string token,int port)
        {
            IPAddress address = IPAddress.Parse(token);// should implemet a method to minimize 
            // the token. 
            // here token is complete ip

            IPEndPoint endPoint=new IPEndPoint(address,port);

            return endPoint;
        }
    }
}