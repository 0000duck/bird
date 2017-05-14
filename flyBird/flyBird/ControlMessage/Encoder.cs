using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace flyBird
{
    public enum Control
    {
        Connected,
        Sendmemac,
        Sendingmac,
        FileComming,
        FileConfiremed,
        FileRejected,
        AudioComming
    }

    public class ControlCommandOccuredEventArgs
    {
        public string id { get; set; }
        public Socket socket { get; set; }
        public Control control { get; set; }
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
                                 text.Substring(text.Length - postfix.Length, postfix.Length) == postfix;
            }

            if (isControl)
            {
                string controlMsg = text.Substring(prefix.Length, text.Length - prefix.Length - postfix.Length);

                Enum.TryParse(controlMsg, out Control control);

                OnControlComamndOccured(id, socket,control);

                return "";
                
            }
            else
            {
                return text;
            }
        }


        public virtual void OnControlComamndOccured(string _id, Socket _socket, Control _control)
        {
            if (ControlCommandOccured != null)
            {
                ControlCommandOccured(this,
                    new ControlCommandOccuredEventArgs() {socket = _socket, id = _id, control = _control});
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