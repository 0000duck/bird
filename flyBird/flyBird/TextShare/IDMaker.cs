using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace flyBird
{
    public static class IDMaker
    {
        public static string getID(IPAddress address)
        {
            return address.ToString();
            //implement a good function to get an id
        }

        

    }
}
