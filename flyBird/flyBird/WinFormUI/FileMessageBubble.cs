using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using flyBird.Messages;

namespace flyBird.WinFormUI
{
    public partial class FileMessageBubble : UserControl
    {
        private Color inMsgColor = AppTheme.chatBubbleInColor;
        private Color outMsgColor = AppTheme.chatBubbleOutColor;

        private Color inMsgTextColor = AppTheme.chatBubbleInTextColor;
        private Color outMsgTextColor = AppTheme.chatBubbleOutTextColor;

        private Color inMsgTimeColor = AppTheme.chatBubbleInTimeColor;
        private Color outMsgTimeColor = AppTheme.chatBubbleOutTimeColor;

        private FileShareMiddleController fsmiddleController;


        public FileMessageBubble(FileShareMiddleController fsmc, string time, MsgType messageType)
        {
            InitializeComponent();


            fsmiddleController = fsmc;

            setControllerSubscriptions(fsmc);

            this.bubbleTime.Text = time;

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
            fileShareMiddleController.ChangedProgress += OnTransferClientProgressChanged;

            fileShareMiddleController.QueuedTransferClient += OnTransferClientQueued;
            fileShareMiddleController.CompletedTransferClient += OnTransferClientCompleted;
            fileShareMiddleController.StopedTransferClient += OnTransferClientStopped;

            setProgressChangeSubscription();
        }

        public void setProgressChangeSubscription()
        {
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
            lstTransfers.Items[queue.ID.ToString()].Remove();
        }

        public void OnTransferClientQueued(object sender, TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new TransferEventHandler(OnTransferClientQueued), sender, queue);
                return;
            }


            ListViewItem i = new ListViewItem();
            i.Text = queue.ID.ToString();
            i.SubItems.Add(queue.FileName);
//            i.SubItems.Add(queue.Type == QueueType.Download ? "Download" : "Upload");
            i.SubItems.Add("0%");
            i.Tag = queue;
            i.Name = queue.ID.ToString();
            tempLastFile = queue.FileName;
            lstTransfers.Items.Add(i);
            i.EnsureVisible();
        }


        private string tempLastFile = "";

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
            if (lstTransfers.Items != null)
            {
                int x = queue.Progress;

                lstTransfers.Items[queue.ID.ToString()].SubItems[2].Text = x + "%";
                int overallProgress = fsmiddleController.getOverallProgress();
                showOverallProgress(overallProgress);
                if (overallProgress == 100)
                {
                    Console.WriteLine("complete...");

                    unsetControllerSubscriptions(fsmiddleController);
                }
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


            lstTransfers.Items.Clear();
            overallProgressBar.Value = 0;

//            setConnectionStatus("-");
//
//            if (mc.serverRunning)
//            {
//                setConnectionStatus("Waiting...");
//            }
//            else
//            {
//                setConnectBtnText("Connect");
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\test");
        }

        public void outputButton_Click(object sender, EventArgs e)
        {
            string abspath = Path.GetFullPath(@settings.Default.outputFolder);

            string path = abspath + "\\" + tempLastFile;

            Console.WriteLine("Output path" + path);


            if (File.Exists(path))
            {
                Process.Start("explorer.exe", "/select, " + path);
            }
        }

        private void fileOpenBtn_Click(object sender, EventArgs e)
        {
            string abspath = Path.GetFullPath(@settings.Default.outputFolder);

            string path = abspath + "\\" + tempLastFile;

            Console.WriteLine("Output path" + path);

            Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }

    ////
}