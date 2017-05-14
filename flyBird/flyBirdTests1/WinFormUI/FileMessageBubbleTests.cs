using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird.WinFormUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using flyBird.Messages;

namespace flyBird.WinFormUI.Tests
{
    [TestClass()]
    public class FileMessageBubbleTests
    {
        [TestMethod()]
        public void outputButton_ClickTest()
        {
            string abspath = Path.GetFullPath(@"Transfers");

            Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = abspath,
                UseShellExecute = true,
                Verb = "open"
            });

        }

        [TestMethod()]
        public void outputButton_ClickTest1()
        {
           new FileMessageBubble(new FileShareMiddleController(), "bla",MsgType.IN).outputButton_Click(this,EventArgs.Empty);
        }
    }
}