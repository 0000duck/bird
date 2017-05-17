using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using flyBird.Contacts;

namespace flyBird
{
    public static class StorageHandler
    {


        private static string contactsFileLocation=@"Contacts\\MyContacts.bin";


        public static void updateMyContactsFile(ContactsStore cs)
        {
            System.IO.Directory.CreateDirectory("Contacts");
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(contactsFileLocation,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, cs);
            stream.Close();

        }

        public static bool doesContactsFileExistInDerectory()
        {
            return File.Exists(contactsFileLocation);
        }


        public static ContactsStore getContactsStore()
        {
            if (doesContactsFileExistInDerectory())
            {

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(contactsFileLocation,
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                ContactsStore cs = (ContactsStore)formatter.Deserialize(stream);
                stream.Close();

                return cs;
            }
            Console.WriteLine("Contacts file not found");
            return null;

        }
    }
}