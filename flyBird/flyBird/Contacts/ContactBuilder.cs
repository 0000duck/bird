using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.Contacts
{
    public class ContactBuilder
    {
        ContactBuilder()
        {
//            ControlHandler.getInstance().ContactUpdate += OnContactUpdateReceived;
        }

        private void OnContactUpdateReceived(object sender, ControlCommandOccuredEventArgs e)
        {
            var contact = getContactFromReceivedData(e.data);
            contact.currentIp = e.id;
            ContactsStore.getInstance().addContact(contact.mac, contact);
        }

        public static string getSendingControlData(Contact contact)
        {
            string data = "";

            data += "*"+contact.mac + "_*";
            data += contact.name + "_*";
            data += contact.currentIp;

            //data="*mac_*name_*ip"
            return data;
        }

        public static Contact getContactFromReceivedData(string data)
        {
            //data=*45656efceeccece_*kasun_*138.456.245.453

            var contact = new Contact();
            string[] dataset = data.Split('_');

            contact.mac = dataset[0].Remove(0,1);
            contact.name = dataset[1].Remove(0, 1);
            contact.currentIp = dataset[2].Remove(0, 1);

            return contact;
        }


        public static string GetMacAddress()
        {
            var macAddr =
            (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            return macAddr;
        }
    }
}