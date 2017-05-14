using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirdUI1;

namespace flyBird
{



    public partial class AudioRecorder : Form
    {
        private Timer timer;

        private string path;
        private string filePath;



        private Stopwatch stopWatch;
        private System.Media.SoundPlayer player;

        private bool start = true;
        private bool playing = false;

        private ChatDisplay chatDisplay;

        public AudioRecorder(ChatDisplay cd)
        {
            InitializeComponent();

            path = getPath();
            filePath = getPath()+"\\recorded"+DateTime.Now.Ticks+".wav";

            recordingIcon.Visible = false;

            timer = new Timer();
            timer.Interval = 25;
            timer.Tick += timerTick;
            player = new System.Media.SoundPlayer(filePath);

            timeLabel.Text = "";
            

            stopWatch = new Stopwatch();

            chatDisplay = cd;
        }


        public string getPath()
        {
             string path = Path.GetFullPath(settings.Default.audioPath);


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private void timerTick(object sender, EventArgs e)
        {
//           Console.WriteLine(showTime(stopWatch)); 

            timeLabel.Text = showTime(stopWatch);
        }

        #region record

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi,
            SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength,
            int hwndCallback);

        private void startButton_Click(object sender, EventArgs e)
        {
            if (start)
            {
                startButton.Text = "Stop and Save";
                recordAudio();
                recordingIcon.Visible = true;
                start = false;
            }
            else
            {
                stopAndSave();
                recordingIcon.Visible = false;
                stopWatch.Reset();
                start = true;
                startButton.Text = "Start";
            }
        }

        private void recordAudio()
        {
            timer.Enabled = true;
            stopWatch.Start();
            timer.Start();
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
        }

        private void stopAndSave()
        {
            timer.Stop();
            stopWatch.Stop();
            timer.Enabled = false;
            record("save recsound "+filePath, "", 0, 0);
            record("close recsound", "", 0, 0);
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            if (playing)
            {
               
           
                stopPlaying();
                playing = false;
            }
            else
            {
               
                startPlaying();

                playing = true;
            }
        }


        private void startPlaying()
        {
          
            player.Play();
           

        }

        private void stopPlaying()
        {
            player.Stop();
        }

        #endregion

        private string showTime(Stopwatch stopWatch)
        {
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            return elapsedTime;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
           
            chatDisplay.OnAudioSendButtonClicked(filePath);
            this.Dispose();
        }

        private void directory_Click(object sender, EventArgs e)
        {
            string abspath = path;

          
            Console.WriteLine(path);

            Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = abspath,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void AudioRecorder_Load(object sender, EventArgs e)
        {

        }
    }
}