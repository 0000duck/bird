using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace flyBird.Tests
{
    [TestClass()]
    public class EncoderTests
    {
        [TestMethod()]
        public void checkForControlTest()
        {
  

            string cmsg = Encoder.getInstance().getControlMsg(Control.ContactUpdateCc.ToString())+"this is data";

            Console.WriteLine("Msg="+cmsg);

            Encoder.getInstance().checkForControl("id", new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp), cmsg);


        }

    }
}