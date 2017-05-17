using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            myProfile.currentIp= IpDetails.getInstance().getMyLocalIp();

            StorageHandler.updateMyContactsFile(this);

            sendMyContactToAll();
        }

        public void sendMyContactToAll()
        {
            foreach (var ip in SocketStore.getInstance().getAllConnectedIps())
            {
                
                ControlMessage.getInstance().sendContactUpdateSignal(ip, myProfile);
            }
        }

        public void sendMyContactToOne(string ip)
        {
            ControlMessage.getInstance().sendContactUpdateSignal(ip, myProfile);
        }
    }
}