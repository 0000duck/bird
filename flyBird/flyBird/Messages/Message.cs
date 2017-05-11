using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.Messages
{
    public class Message
    {
        public Message()
        {
            time=DateTime.Now;
        }
        public DateTime time { set; get; }
        public string ipToken { set; get; }

    }
}
