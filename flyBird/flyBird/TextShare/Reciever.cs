using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using flyBird.Encryptor;

namespace flyBird
{
    public class TextMessageRecivedEventArgs : EventArgs
    {
        public string text { get; set; }
        public string id { get; set; }
    }

    class Reciever
    {
        public event EventHandler<TextMessageRecivedEventArgs> TextMessageReceived;

        public void OnNewSoketAdded(object source, SocketAddedEventArgs e)
        {
            string id = e.id;
            Socket socket = e.socket;


            

            new Thread(() =>
            {
                //listening
                {
                    while (true)
                    {
                        if (socket != null)
                        {
                            receiveTextMessage(id, socket);
                        }
                    }
                }
            }).Start();
            Console.WriteLine("new listening thread started for id=" + id);
        }


//        private void confirmConnectionToConnectedDevice(Socket socket)
//        {
//            byte[] sendBuffer;
//
//            sendBuffer =
//                Encoding.Default.GetBytes(settings.Default.controlPrefix + Control.ConnectedCccccc.ToString() +
//                                          settings.Default.controlPostfix);
//            try
//            {
//                socket.Send(sendBuffer, 0, sendBuffer.Length, 0);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                throw;
//            }
//        }

        private void receiveTextMessage(string id, Socket socket)
        {
            //byte[] sendBuffer = null;


            byte[] recievedBuffer = new byte[255];

            try
            {
                if (socket.Connected && recievedBuffer!=null)

                {

                    int receivedSize = socket.Receive(recievedBuffer, 0, recievedBuffer.Length, 0); //need fixed when forced closed
                    Array.Resize(ref recievedBuffer, receivedSize);

                    string receivedText = Encoding.Default.GetString(recievedBuffer);

                    //checking for control msgs
                    string text = Encoder.getInstance().checkForControl(id, socket, receivedText);


                    //then this passes only msgs that are not control msgs to forward.
                    if (text.Length > 0)
                    {
                        
                        //decrypting function here
                       //string decrypted= EncryptDecrypt.Decrypt(receivedText);


                        OnTextMessageReceived(id, receivedText);
                        //text msg processing loogic here
                        Console.WriteLine("Recieved: {0}\nfrom: {1}", text, id); //show in console
                    }
                }
            }
            catch (Exception e)
            {
                socket.Close();
                MiddleController.getInstance().disconnectHandle(id);
                Console.WriteLine(e);
            }
        }

        private void OnTextMessageReceived(string id_, string txt)
        {
            if (TextMessageReceived != null)
            {
                TextMessageReceived(this, new TextMessageRecivedEventArgs() {text = txt, id = id_});
            }
        }
    }
}