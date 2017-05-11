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
    public class HotspotTests
    {
        [TestMethod()]
        public void createHotspotTest()
        {
            Hotspot.getInstance().createHotspot("dkTestWIfi","123456789",true);
        }
    }
}