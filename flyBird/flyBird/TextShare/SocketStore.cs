using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace flyBird
{
    public class SocketAddedEventArgs : EventArgs
    {
        public Socket socket { get; set; }
        public string id { get; set; }
    }

    class SocketStore
    {
        #region event

        public event EventHandler<SocketAddedEventArgs> SocketAdded;

        protected virtual void OnSocketAdded(string addedId, Socket addedOne)
        {
            if (SocketAdded != null)
            {
                SocketAdded(this, new SocketAddedEventArgs() {socket = addedOne, id = addedId});
            }
        }

        #endregion

        public Dictionary<string, Socket> SocketDic;

        #region staticInstance

        private static SocketStore instance;
       
        private SocketStore()
        {
            SocketDic=new Dictionary<string, Socket>();
        }

        public static SocketStore getInstance()
        {
            if (instance == null)
            {
                instance = new SocketStore();
            }

            return instance;
        }

        #endregion

        public void addSocket(string key, Socket socket)
        {
            //keychecking logic should be here

            SocketDic[key] = socket;

            OnSocketAdded(key,socket); //fire the event
        }

        public void OnSocketCreated(object source, SocketAddedEventArgs e)  
            //this will call addSocket. this was fired by serverpart of app
            //when a client
            // accepted
        {
            addSocket(e.id,e.socket);       
        }

        public Socket getSocket(string key)
        {
            if (SocketDic.ContainsKey(key))
            {
                return SocketDic[key];
            }
            else
            {
                return null;
            }
        }
        
    }
}