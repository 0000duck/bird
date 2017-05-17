using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using flyBird.Contacts;

namespace flyBird
{

    public enum Control
    {
        ConnectedCccccc,
        SendmemacCccccc,
        SendingmacCcccc,
        FileCommingCccc,
        FileConfiremedC,
        FileRejectedCcc,
        AudioCommingCcc,
        ContactUpdateCc
    }
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



        public void sendConnectedSignal(string iptoken)
        {
            sendControlMessage(iptoken,Control.ConnectedCccccc, null);
        }
        public void sendFileCommingSignal(string iptoken)
        {
            sendControlMessage(iptoken, Control.FileCommingCccc,null);
        }

        public void sendFileRejectedSignal(string iptoken)
        {
            sendControlMessage(iptoken, Control.FileRejectedCcc,null);
        }

        public void sendFileConfirmSignal(string iptoken)
        {
            sendControlMessage(iptoken,Control.FileConfiremedC,null);
        }

        public void sendAudioCommingSignal(string iptoken)
        {
            sendControlMessage(iptoken, Control.AudioCommingCcc,null);
        }

       


        public void sendContactUpdateSignal(string iptoken,Contact contact)   //in a test of the method, original has no return
        {
            string data = ContactBuilder.getSendingControlData(contact);
            sendControlMessage(iptoken,Control.ContactUpdateCc,ContactBuilder.getSendingControlData(contact));
//            return data;
        }

        private void sendControlMessage(string iptoken,Control control,string data)
        {
            Socket sck = SocketStore.getInstance().getSocket(iptoken);

            string msg = settings.Default.controlPrefix +
                         control.ToString() +
                         settings.Default.controlPostfix +
                         data;
            Console.WriteLine("sending control message: "+msg+"\ncontrol message sending to:"+iptoken);

            byte[] sendBuffer = Encoding.Default.GetBytes(msg);

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
