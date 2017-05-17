using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace flyBird
{


    public class ControlCommandOccuredEventArgs
    {
        public string id { get; set; }
        public Socket socket { get; set; }
        public Control control { get; set; }
        public string data { get; set; }
    }

    public class Encoder
    {
        #region staticInstance

        private static Encoder instance;

        private Encoder()
        {
        }

        public static Encoder getInstance()
        {
            if (instance == null)
            {
                instance = new Encoder();
            }

            return instance;
        }

        #endregion
       private string prefix = settings.Default.controlPrefix;
       private string postfix = settings.Default.controlPostfix;

        public event EventHandler<ControlCommandOccuredEventArgs> ControlCommandOccured;

        public string checkForControl(string id, Socket socket,string text)
        {
//        public string checkForControl(string text,string id )
//        {
            bool isControl=false;
            if (text.Length > postfix.Length + prefix.Length)
            {

               isControl = text.Substring(0, prefix.Length) == prefix &&
                                 text.Substring(18, postfix.Length) == postfix;
            }

            if (isControl)
            {
                string controlMsg = text.Substring(prefix.Length, 15);
                string data = text.Substring(20, text.Length - 20);

                Enum.TryParse(controlMsg, out Control control);

                OnControlComamndOccured(id, socket,control,data);

                Console.WriteLine("control command="+controlMsg+"\ndata="+data);

                return "";
                
            }
            else
            {
                return text;
            }
        }


        public virtual void OnControlComamndOccured(string _id, Socket _socket, Control _control,string data_)
        {
            if (ControlCommandOccured != null)
            {
                ControlCommandOccured(this,
                    new ControlCommandOccuredEventArgs() {socket = _socket, id = _id, control = _control,data=data_});
            }
        }


        public string getControlMsg(string controlWord)
        {
            string controlMsg;
            controlMsg = prefix + controlWord + postfix;
            return controlMsg;
        }
    }
}