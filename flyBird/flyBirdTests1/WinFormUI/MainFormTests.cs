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
    public class MainFormTests
    {
        [TestMethod()]
        public void GetFormTest()
        {

            MainForm.Instance.Show();
         
        }
    }
}