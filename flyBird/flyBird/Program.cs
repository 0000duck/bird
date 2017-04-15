using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using BirdUI1;

namespace flyBird
{
    class Program
    {
        public static Random Rand = new Random();


        [STAThread]
        static void Main(string[] args)
        {
//            Application.Run(new chatApp());
            Application.Run(MainForm.Instance);
        }
    }
}