using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird.Encryptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.Encryptor.Tests
{
    [TestClass()]
    public class EncryptDecryptTests
    {
        [TestMethod()]
        public void encryptTest()
        {
            string msg="hi";
            string en = EncryptDecrypt.Encrypt(msg);
            Console.WriteLine("encrypted: "+en);

            string de = EncryptDecrypt.Decrypt(en);
            Console.WriteLine("encrypted: "+de);

            Assert.AreEqual(de,msg);
        }
    }
}