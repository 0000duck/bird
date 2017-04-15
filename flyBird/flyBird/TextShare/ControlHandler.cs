using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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

     

        public void OnControlOccured(object sender, ControlCommandOccuredEventArgs e)
        {
            controlSelect(sender,e);
        }


        private void controlSelect(object sender, ControlCommandOccuredEventArgs e)
        {

           Control typeOfControl = e.control;

            switch (typeOfControl)
            {
                case Control.Connected:
                    connectedControl(e);
                    break;
                case  Control.Sendmemac:
                    sendMacControl(e);
                    break;
                case Control.Sendingmac:
                    macReceivedControl(e);
                    break;
                default:
                    break;
            }
        }

        private void macReceivedControl(ControlCommandOccuredEventArgs e)
        {
            
           EndPoint ip= e.socket.RemoteEndPoint;
            //mac recieved from ip
        }

        private void sendMacControl(ControlCommandOccuredEventArgs e)
        {

            EndPoint ip = e.socket.RemoteEndPoint;
            //send mac 
        }

        private void connectedControl(ControlCommandOccuredEventArgs e)
        {
            
            EndPoint ip = e.socket.RemoteEndPoint;
            //im connected to this ip
        }
    }
}