using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.HotspotAndIP
{
    public class Hotspot
    {
        #region staticInstance

        private static Hotspot instance;


        private Hotspot()
        {
        }

        public static Hotspot getInstance()
        {
            if (instance == null)
            {
                instance = new Hotspot();
            }

            return instance;
        }

        #endregion

        private Process process;

        private void setCmd()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;

            process = Process.Start(processStartInfo);
        }

        public static bool Running { private set; get; }

        public void createHotspot(string ssid, string key)
        {
            setCmd();
            if (process != null)
            {
                process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + key);
                process.StandardInput.WriteLine("netsh wlan start hosted network");
                process.StandardInput.Close();
                Running = true;
            }
        }

        public void stopHotspot()
        {
            setCmd();
            process.StandardInput.WriteLine("netsh wlan stop hostednetwork");
            process.StandardInput.Close();
            Running = false;
        }
    }
}