using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird.HotspotAndIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.HotspotAndIP.Tests
{
    [TestClass()]
    public class IpDetailsTests
    {
        [TestMethod()]
        public void getMyLocalIpTest()
        {
            var ip = IpDetails.getInstance().getMyLocalIp();

            Console.WriteLine("Local ip is: " + ip);
            //            Assert.Fail();
        }

        [TestMethod()]
        public void isConnectedToNetworkTest()
        {
            Console.WriteLine(IpDetails.getInstance().isConnectedToNetwork());
        }
    }
}