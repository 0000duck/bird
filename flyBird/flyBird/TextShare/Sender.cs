using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.TextShare
{
    public class SentMessageEventArgs : EventArgs
    {
        public string text { set; get; }
    }

    class Sender
    {

        public event EventHandler<SentMessageEventArgs> MessageSent;
        private byte[] sendBuffer;

        #region staticInstance

        private static Sender instance;

        private Sender()
        {
        }

        public static Sender getInstance()
        {
            if (instance == null)
            {
                instance = new Sender();
            }

            return instance;
        }

        #endregion

        public void sendMessage(string text, Socket socket)
        {
            sendBuffer = Encoding.Default.GetBytes(text);
            try
            {
                if (socket.Connected)
                {
                    socket.Send(sendBuffer, 0, sendBuffer.Length, 0);


                    OnMessageSent(text);
                }
               

            }
            catch (Exception e)
            {
               
              
            }
           
        }


        protected virtual void OnMessageSent(string txt)
        {
            if (MessageSent != null)
            {
                MessageSent(this, new SentMessageEventArgs() {text = txt});
            }
        }
    }
}