using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace filSharePart
{
    public partial class UI : Form
    {
        private System.Timers.Timer tmrOverallProg;


        private FileShareMiddleController mc = new FileShareMiddleController(); ////

        public UI()
        {
            InitializeComponent();

            mc.initialize(); ////

            tmrOverallProg = new System.Timers.Timer();

            tmrOverallProg.Interval = 100;

            tmrOverallProg.Elapsed += tmrOverallProg_Tick;

            setBtnSubscriptions();

            setControllerSubscriptions(mc); ////


            serverStopBtn.Enabled = false;
        }

        private void setControllerSubscriptions(FileShareMiddleController middleController)
        {
            middleController.Connected += OnConnected;
            middleController.DisconnectedTransferClient += OnTransferClientDisconnected;
            middleController.ChangedProgress += OnTransferClientProgressChanged;
            middleController.QueuedTransferClient += OnTransferClientQueued;
            middleController.CompletedTransferClient += OnTransferClientCompleted;
            middleController.StopedTransferClient += OnTransferClientStopped;
        }

        private void setBtnSubscriptions()
        {
            connectBtn.Click += new EventHandler(btnConnect_Click);
            serverStartBtn.Click += new EventHandler(btnStartServer_Click);
            serverStopBtn.Click += new EventHandler(btnStopServer_Click);
            sendBtn.Click += new EventHandler(btnSendFile_Click);
            pauseToolStripMenuItem.Click += new EventHandler(btnPauseTransfer_Click);
            stopToolStripMenuItem.Click += new EventHandler(btnStopTransfer_Click);
            openDirBtn.Click += new EventHandler(btnOpenDir_Click);
            clearCompleteToolStripMenuItem.Click += new EventHandler(btnClearComplete_Click);
        }

        #region buttons

        private void btnClearComplete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstTransfers.Items)
            {
                TransferQueue queue = (TransferQueue) i.Tag;

                if (mc.getProgressOf(queue) == 100 || !mc.isQueueRunninig(queue)) ////
                {
                    i.Remove();
                }
            }
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fb = new FolderBrowserDialog())
            {
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = fb.SelectedPath;

                    mc.setOutputFolder(path); ////

                    directoryLabel.Text = path;
                }
            }
        }

        private void btnStopTransfer_Click(object sender, EventArgs e)
        {
            if (!mc.hasTransferClientInitialized()) ////
                return;

            foreach (ListViewItem i in lstTransfers.SelectedItems)
            {
                TransferQueue queue = (TransferQueue) i.Tag;
                mc.stopQueue(queue); ////
                i.Remove();
            }

            progressBar.Value = 0;
        }


        private void btnPauseTransfer_Click(object sender, EventArgs e)
        {
            if (!mc.hasTransferClientInitialized()) ////
                return;

           

            foreach (ListViewItem i in lstTransfers.SelectedItems)
            {
                TransferQueue queue = (TransferQueue) i.Tag;
                mc.pauseOrStartQueue(queue); ////
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            mc.chooseAndSendFile(); ////
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (mc.stopServer()) ////
            {
                tmrOverallProg.Stop();
                setConnectionStatus("_");
                serverStartBtn.Enabled = true;
                serverStopBtn.Enabled = false;
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (mc.startServer(txtServerPort.Text)) ////
            {
                setConnectionStatus("Waiting...");
                serverStartBtn.Enabled = false;
                serverStopBtn.Enabled = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            mc.connectOrDisconnect(connectIpText.Text, connectPortText.Text); ////
        }

        #endregion

        #region logics

        private void tmrOverallProg_Tick(object sender, EventArgs e)
        {

 
            showOverallProgress(mc.getOverallProgress());
           
        } 



        public void OnConnected(object source, string ip) //from an mc event
        {
            setConnectionStatus(ip);
            setConnectBtnText("Disconnect");
            tmrOverallProg.Start();

           
        }


        private void OnTransferClientStopped(object sender, TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new TransferEventHandler(OnTransferClientStopped), sender, queue);
                return;
            }
            lstTransfers.Items[queue.ID.ToString()].Remove();
        }

        private void OnTransferClientQueued(object sender, TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new TransferEventHandler(OnTransferClientQueued), sender, queue);
                return;
            }
            ListViewItem i = new ListViewItem();
            i.Text = queue.ID.ToString();
            i.SubItems.Add(queue.FileName);
            i.SubItems.Add(queue.Type == QueueType.Download ? "Download" : "Upload");
            i.SubItems.Add("0%");
            i.Tag = queue;
            i.Name = queue.ID.ToString();
            lstTransfers.Items.Add(i);
            i.EnsureVisible();
        }

        private void OnTransferClientProgressChanged(object sender, TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new TransferEventHandler(OnTransferClientProgressChanged), sender, queue);
            }
            progressSet(queue);
        }

        private void progressSet(TransferQueue queue)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<TransferQueue>(progressSet), queue);
                return;
            }
            lstTransfers.Items[queue.ID.ToString()].SubItems[3].Text = queue.Progress + "%";
        }

        private void OnTransferClientDisconnected(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler(OnTransferClientDisconnected), sender, e);
                return;
            }


            lstTransfers.Items.Clear();
            progressBar.Value = 0;

            setConnectionStatus("-");

            if (mc.serverRunning)
            {
                setConnectionStatus("Waiting...");
            }
            else
            {
                setConnectBtnText("Connect");
            }
        }


        private void OnTransferClientCompleted(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler(OnTransferClientCompleted), sender, e);
                return;
            }
        }

        private void transferClient_Complete(object sender, TransferQueue queue)
        {
            System.Media.SystemSounds.Asterisk.Play();
        }


        private void setConnectionStatus(string connectedTo)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(setConnectionStatus), connectedTo);
                return;
            }

            lblConnected.Text = "Connection: " + connectedTo;
        }

        private void setConnectBtnText(string txt)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(setConnectBtnText), txt);
                return;
            }

            connectBtn.Text = txt;
        }


        private void showOverallProgress(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(showOverallProgress), value);
                return;
            }

            progressBar.Value = value;
        }

        #endregion

        private void UI_Load(object sender, EventArgs e)
        {

        }
    }
}