using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace flyBird
{
    public class ControlMessage
    {

        #region staticInstance
        private static ControlMessage instance;

        private ControlMessage()
        {

        }

        public static ControlMessage getInstance()
        {
            if (instance == null)
            {
                instance = new ControlMessage();
            }

            return instance;
        }

        #endregion

        public void sendFileCommingSignal(string iptoken)
        {
            sendControlMessage(iptoken, Control.FileComming);
        }

        public void sendFileRejectedSignal(string iptoken)
        {
            sendControlMessage(iptoken, Control.FileRejected);
        }

        public void sendFileConfirmSignal(string iptoken)
        {
            sendControlMessage(iptoken,Control.FileConfiremed);
        }

        public void sendAudioCommingSignal(string iptoken)
        {
            sendControlMessage(iptoken, Control.AudioComming);
        }

        private void sendControlMessage(string iptoken,Control control)
        {
            Socket sck = SocketStore.getInstance().getSocket(iptoken);

            byte[] sendBuffer = Encoding.Default.GetBytes(
                settings.Default.controlPrefix +
                control.ToString() +
                settings.Default.controlPostfix);
            try
            {
                sck.Send(sendBuffer, 0, sendBuffer.Length, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        
    }
}
