using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.HotspotAndIP
{
    public class IpDetails
    {
        #region staticInstance

        private static IpDetails instance;


        private IpDetails()
        {
        }

        public static IpDetails getInstance()
        {
            if (instance == null)
            {
                instance = new IpDetails();
            }

            return instance;
        }

        #endregion


        //check connect or not 
        // System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        public bool isConnectedToNetwork()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }


        //get ip address
        public string getMyLocalIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }
}