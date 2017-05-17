using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.Tests
{
    [TestClass()]
    public class ControlMessageTests
    {
        [TestMethod()]
        public void sendContactUpdateSignalTest()
        {
            var contact=new Contact(){mac="565656c6d5c6ec",currentIp = "456.244.36",name = "dushan"};
//            var data=ControlMessage.getInstance().sendContactUpdateSignal("ip", contact);
//            Console.WriteLine(data);
        }

    }
}