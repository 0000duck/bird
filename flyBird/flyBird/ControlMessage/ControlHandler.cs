using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flyBird
{
    class ControlHandler
    {
        #region staticInstance

        private static ControlHandler instance;

        private ControlHandler()
        {
        }

        public static ControlHandler getInstance()
        {
            if (instance == null)
            {
                instance = new ControlHandler();
            }

            return instance;
        }

        #endregion

        public event EventHandler<ControlCommandOccuredEventArgs> FileComming;

        public event EventHandler<ControlCommandOccuredEventArgs> FileConfirmed;

        public event EventHandler<ControlCommandOccuredEventArgs> FileRejected;

        public event EventHandler<ControlCommandOccuredEventArgs> AudioComming;

        public event EventHandler<ControlCommandOccuredEventArgs> ContactUpdate;

        public event EventHandler<ControlCommandOccuredEventArgs> Connected;

        public void OnControlOccured(object sender, ControlCommandOccuredEventArgs e)
        {
            controlSelect(sender, e);
        }


        private void controlSelect(object sender, ControlCommandOccuredEventArgs e)
        {
            Control typeOfControl = e.control;

            switch (typeOfControl)
            {
                case Control.ConnectedCccccc:
                    connectedControl(e);
                    break;
                case Control.SendmemacCccccc:
                    sendMacControl(e);
                    break;
                case Control.SendingmacCcccc:
                    macReceivedControl(e);
                    break;
                case Control.FileCommingCccc:
                    fileComming(e);
                    break;
                case Control.FileConfiremedC:
                    fileConfiremed(e);
                    break;
                case Control.FileRejectedCcc:
                    fileRejected(e);
                    break;
                case Control.AudioCommingCcc:
                    audioComming(e);
                    break;
                case Control.ContactUpdateCc:
                    updateContact(e);
                    break;
                default:
                    break;
            }
        }

        private void updateContact(ControlCommandOccuredEventArgs e)
        {
            if (ContactUpdate != null) ContactUpdate(this, e);
        }

        private void audioComming(ControlCommandOccuredEventArgs e)
        {
            if (AudioComming != null) AudioComming(this, e);
        }

        private void fileConfiremed(ControlCommandOccuredEventArgs e)
        {
            if (FileConfirmed != null) FileConfirmed(this, e);
        }

        private void fileRejected(ControlCommandOccuredEventArgs e)
        {
            if (FileRejected != null) FileRejected(this, e);
        }

        private void fileComming(ControlCommandOccuredEventArgs e)
        {
            if (FileComming != null) FileComming(this, e);
        }

        private void macReceivedControl(ControlCommandOccuredEventArgs e)
        {
            EndPoint ip = e.socket.RemoteEndPoint;
            //mac recieved from ip
        }

        private void sendMacControl(ControlCommandOccuredEventArgs e)
        {
            EndPoint ip = e.socket.RemoteEndPoint;
            //send mac 
        }

        private void connectedControl(ControlCommandOccuredEventArgs e)
        {
            if (Connected != null) Connected(this, e);
            
        }
    }
}