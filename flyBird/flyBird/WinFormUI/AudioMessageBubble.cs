using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using flyBird.Messages;

namespace flyBird.WinFormUI
{
    public partial class AudioMessageBubble : UserControl
    {
        private Color inMsgColor = AppTheme.chatBubbleInColor;
        private Color outMsgColor = AppTheme.chatBubbleOutColor;

        private Color inMsgTextColor = AppTheme.chatBubbleInTextColor;
        private Color outMsgTextColor = AppTheme.chatBubbleOutTextColor;

        private Color inMsgTimeColor = AppTheme.chatBubbleInTimeColor;
        private Color outMsgTimeColor = AppTheme.chatBubbleOutTimeColor;

        private FileShareMiddleController fsmiddleController;

        private MsgType type;

        private string outPath;
        private string inPath;
        private string fileName;
        private string filePath;


        public AudioMessageBubble(FileShareMiddleController fsmc, string time, MsgType messageType)
        {
            InitializeComponent();

            inPath = Path.GetFullPath(settings.Default.audioInPath);

            outPath = Path.GetFullPath(settings.Default.audioPath);

            fsmiddleController = fsmc;

            setControllerSubscriptions(fsmc);

            this.bubbleTime.Text = time;

            type = messageType;
            if (messageType.ToString() == "IN")
            {
                //incomming Message 
                this.BackColor = inMsgColor;
//                this.bubbleText.ForeColor = inMsgTextColor;
                this.bubbleTime.ForeColor = inMsgTimeColor;
            }
            else
            {
                //outGoing
                this.BackColor = outMsgColor;
//                this.bubbleText.ForeColor = outMsgTextColor;
                this.bubbleTime.ForeColor = outMsgTimeColor;
            }
        }


        private void setControllerSubscriptions(FileShareMiddleController fileShareMiddleController)
        {
            fileShareMiddleController.Connected += OnConnected;
            fileShareMiddleController.DisconnectedTransferClient += OnTransferClientDisconnected;


            fileShareMiddleController.QueuedTransferClient += OnTransferClientQueued;

            fileShareMiddleController.CompletedTransferClient += OnTransferClientCompleted;

            fileShareMiddleController.StopedTransferClient += OnTransferClientStopped;

            fsmiddleController.ChangedProgress += OnTransferClientProgressChanged;
        }


        private void unsetControllerSubscriptions(FileShareMiddleController fileShareMiddleController)
        {
            fileShareMiddleController.Connected -= OnConnected;
            fileShareMiddleController.DisconnectedTransferClient -= OnTransferClientDisconnected;
            fileShareMiddleController.ChangedProgress -= OnTransferClientProgressChanged;

            fileShareMiddleController.QueuedTransferClient -= OnTransferClientQueued;
            fileShareMiddleController.CompletedTransferClient -= OnTransferClientCompleted;
            fileShareMiddleController.StopedTransferClient -= OnTransferClientStopped;
        }

        private void OnConnected(object sender, string ip)
        {
        }

        public void setOverallProgress(int value)
        {
            overallProgressBar.Value = value;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        //// imported code
        private void OnTransferClientStopped(object sender, TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new TransferEventHandler(OnTransferClientStopped), sender, queue);
                return;
            }
        }

        public void OnTransferClientQueued(object sender, TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new TransferEventHandler(OnTransferClientQueued), sender, queue);
                return;
            }


            fileName = queue.FileName;
            filePath = inPath + "\\"+fileName;
        }


        private void OnTransferClientProgressChanged(object sender, TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new TransferEventHandler(OnTransferClientProgressChanged), sender, queue);
            }
            progressSet(queue);
        }

        private void OnTransferClientCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("tc completd evnt method on bbl");
            if (InvokeRequired)
            {
                Invoke(new EventHandler(OnTransferClientCompleted), sender, e);
                return;
            }
            Console.WriteLine("Unsubcribing bbl");
            unsetControllerSubscriptions(fsmiddleController);
        }

        private void progressSet(TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<TransferQueue>(progressSet), queue);
                return;
            }


            int overallProgress = fsmiddleController.getOverallProgress();
            showOverallProgress(overallProgress);
            if (overallProgress == 100)
            {
                Console.WriteLine("complete...");

                unsetControllerSubscriptions(fsmiddleController);
            }
        }

        private void showOverallProgress(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(showOverallProgress), value);
                return;
            }

            overallProgressBar.Value = value;
        }

        private void OnTransferClientDisconnected(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler(OnTransferClientDisconnected), sender, e);
                return;
            }


            overallProgressBar.Value = 0;
        }


        public void outputButton_Click(object sender, EventArgs e)
        {
            string abspath = Path.GetFullPath(@settings.Default.outputFolder);

            Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = abspath,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string path=settings.Default.audioPath+"\\"+fileName;
            
            if (type.ToString()=="IN")
            {
                path = Path.GetFullPath(filePath);
            }
           

            var player = new System.Media.SoundPlayer(path);

            player.Play();
        }
    }

    ////
}