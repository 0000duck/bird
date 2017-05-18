using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird.Contacts;
using System;
using System.Collections.Generic;
using System.IO;
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
            ContactsStore.getInstance().addContact("dummyMac2", new Contact() { mac = "dummyMac2", name = "Dummy name dummer 2nd" });
        }

        [TestMethod()]
        public void renameAndSendMyPicTest()
        {
            string opath = "C:\\Users\\Dushan\\Desktop\\bird\\flyBird\\flyBird\\bin\\Debug\\Contacts\\2014_mclaren_p1-1920x1080.jpg";
            string ext = Path.GetExtension(opath);
            Console.WriteLine(ext);
            string outPath = "C:\\Users\\Dushan\\Desktop\\bird\\flyBird\\flyBird\\bin\\Debug\\Contacts\\temp\\fileName"+ext;
            System.IO.File.Copy(opath, outPath,true);
        }
    }
}