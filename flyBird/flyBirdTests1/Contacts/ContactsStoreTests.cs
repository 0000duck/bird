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
    public class ContactsStoreTests
    {
        [TestMethod()]
        public void getContactTest()
        {
            var cont = ContactsStore.getInstance().getContact("dummyMac2");

            Console.WriteLine("");

            if (cont == null)
            {
                Console.WriteLine("No contact found");
            }
            else
            {
                Console.WriteLine("mac: " + cont.mac + "\nname: " + cont.name);
            }
        }

        [TestMethod()]
        public void addContactTest()
        {
//            ContactsStore.getInstance().addContact("dummyMac",new Contact(){mac = "dummyMac",name = "Dummy name dummer"});
            ContactsStore.getInstance().addContact("dummyMac2",new Contact(){mac = "dummyMac2",name = "Dummy name dummer 2nd"});
        }
    }
}