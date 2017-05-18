using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace flyBird.Contacts
{
    [Serializable]
    public class ContactsStore
    {
        private Dictionary<string, Contact> contactsDictionary;
        private Contact myProfile;

        #region staticInstance bounded with serialized contacts.bin file

        private static ContactsStore instance;

        private ContactsStore()
        {
            contactsDictionary = new Dictionary<string, Contact>();
        }

        public static ContactsStore getInstance()
        {
            if (instance == null)
            {
                if (StorageHandler.doesContactsFileExistInDerectory())
                {
                    instance = StorageHandler.getContactsStore();
                }
                else
                {
                    instance = new ContactsStore();
                    StorageHandler.updateMyContactsFile(instance);
                }
            }

            return instance;
        }

        #endregion

        public Contact getContact(string mac)
        {
            if (contactsDictionary.ContainsKey(mac))
            {
                return contactsDictionary[mac];
            }
            return null;
        }


        public Contact getMyProfile()
        {
            if (myProfile == null)
            {
                updateMyProfile(ContactBuilder.GetMacAddress(), "", "");
            }

            return myProfile;
        }

        public bool hasSaved(string mac)
        {
            return contactsDictionary.ContainsKey(mac);
        }

        public void addContact(string mac, Contact contact)
        {
            contactsDictionary[mac] = contact;

            StorageHandler.updateMyContactsFile(this);
        }

        public void updateMyProfile(string mac, string name, string dpPath)
        {
            if (myProfile == null)
            {
                myProfile = new Contact();
            }

            myProfile.name = name;
            myProfile.mac = mac;
            myProfile.displayProfile = dpPath;
            myProfile.currentIp = IpDetails.getInstance().getMyLocalIp();

            StorageHandler.updateMyContactsFile(this);

            //sendMyContactToAll();
        }

        public void sendMyContactToAll()
        {
            foreach (var ip in SocketStore.getInstance().getAllConnectedIps())
            {
                sendMyContactToOne(ip);
//                MiddleController.getInstance().fileShareController.sendFile();
            }
        }

        public void sendMyContactToOne(string ip)
        {
            ControlMessage.getInstance().sendContactUpdateSignal(ip, myProfile);

        }


        public void renameAndSendMyPic()
        {
//            string ext = Path.GetExtension(myProfile.displayProfile);
            string originalpath = myProfile.displayProfile;
            string ext = Path.GetExtension(originalpath);

            System.IO.Directory.CreateDirectory("Temp");
            string outPath = "Temp//" + myProfile.mac + ext;

            //System.IO.File.Copy(originalpath, outPath, true);
            if (MiddleController.getInstance().fileShareController.isTransactionGoing())
            {
                return;
            }


          //  MiddleController.getInstance().fileShareController.sendFile(outPath);
            
        }
    }
}