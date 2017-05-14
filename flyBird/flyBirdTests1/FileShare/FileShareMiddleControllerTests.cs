using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.Tests
{
    [TestClass()]
    public class FileShareMiddleControllerTests
    {
       
        [TestMethod()]
        public void chooseAndSendFileTest()
        {
            new FileShareMiddleController().ChooseAndSendFile();
        }
    }
}