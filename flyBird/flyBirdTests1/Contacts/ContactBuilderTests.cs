using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.Contacts.Tests
{
    [TestClass()]
    public class ContactBuilderTests
    {
        [TestMethod()]
        public void getSendingControlDataTest()
        {
            string data = ContactBuilder.getSendingControlData(new Contact() { mac = "", name = "sunil",currentIp = "123.23"});

            Contact cnt = ContactBuilder.getContactFromReceivedData(data);

            Console.WriteLine("mac: " + cnt.mac + "\nname: " + cnt.name+"\ncurrent ip: "+cnt.currentIp);
        }

        [TestMethod()]
        public void GetMacAddressTest()
        {
            string mac=ContactBuilder.GetMacAddress();
            Console.WriteLine("mac is: "+mac);

        }
    }
}