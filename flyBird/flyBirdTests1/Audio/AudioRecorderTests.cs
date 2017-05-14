using flyBird;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using flyBird.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirdUI1;

namespace flyBird.Tests
{
    [TestClass()]
    public class AudioRecorderTests
    {
        [TestMethod()]
        public void getPathTest()
        {
           Console.WriteLine(new AudioRecorder(new ChatDisplay("", new FileShareMiddleController())).getPath()); 
        }
    }
}

namespace flyBird.Audio.Tests
{
    [TestClass()]
    public class AudioRecorderTests
    {
        [TestMethod()]
        public void AudioRecorderTest()
        {
                Application.Run(new AudioRecorder(new ChatDisplay("",new FileShareMiddleController())));
        }
    }
}