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

        public void createHotspot(string ssid, string key,bool status) 
        { 
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe"); 
            processStartInfo.RedirectStandardInput = true; 
            processStartInfo.RedirectStandardOutput = true; 
            processStartInfo.CreateNoWindow = true; 
            processStartInfo.UseShellExecute = false; 
            Process process = Process.Start(processStartInfo); 
 
            if (process != null) 
            { 
                if (status) 
                { 
                    process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + key); 
                    process.StandardInput.WriteLine("netsh wlan start hosted network"); 
                    process.StandardInput.Close(); 
                } 
                else 
                { 
                    process.StandardInput.WriteLine("netsh wlan stop hostednetwork"); 
                    process.StandardInput.Close(); 
                } 
            } 
        }
    }
}