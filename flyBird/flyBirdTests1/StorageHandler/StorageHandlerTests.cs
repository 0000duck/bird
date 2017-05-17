using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using flyBird.Contacts;

namespace flyBird.Tests
{
    [TestClass()]
    public class StorageHandlerTests
    {
        [TestMethod()]
        public void getContactsStoreTest()
        {
            var cs=StorageHandler.getContactsStore();
            var cont=cs.getContact("testMac");

            Console.WriteLine("mac: "+cont.mac+"\nname: "+cont.name);
        }

        [TestMethod()]
        public void updateMyContactsFileTest()
        {
            var cs = ContactsStore.getInstance();
    
            cs.addContact("testMac",new Contact(){mac = "testMac",name="siripala serializer"});
            

            StorageHandler.updateMyContactsFile(cs);
        }
    }
}