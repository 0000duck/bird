using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace flyBird
{
    public delegate void ConnectedEventHandler(object sender, string ip);

    public class FileShareMiddleController
    {
        #region events

        public event ConnectedEventHandler Connected;

        public event TransferEventHandler StopedTransferClient;

        public event EventHandler DisconnectedTransferClient;

        public event TransferEventHandler QueuedTransferClient;

        public event TransferEventHandler Download;

        public event TransferEventHandler ChangedProgress;

        public event EventHandler CompletedTransferClient;


        protected virtual void OnConnected(string iptext)
        {
            if (Connected != null)
            {
                Connected(this, iptext);
            }
        }

        protected virtual void OnStopedTransferClient(TransferQueue queue)
        {
            if (StopedTransferClient != null)
            {
                StopedTransferClient(this, queue);
            }
        }

        protected virtual void OnDisconnectedTransferClient()
        {
            if (DisconnectedTransferClient != null)
            {
                DisconnectedTransferClient(this, EventArgs.Empty);
            }
        }

        protected virtual void OnQueuedTransferClient(TransferQueue queue)
        {
            if (QueuedTransferClient != null)
            {
                QueuedTransferClient(this, queue); //Queue event fireing
            }
        }

        protected virtual void OnChangedProgress(TransferQueue queue)
        {
            if (ChangedProgress != null)
            {
                ChangedProgress(this, queue);
            }
        }

        protected virtual void OnCompletedTransferClient()
        {
            Console.WriteLine("out if");
            if (CompletedTransferClient != null)
            {
                Console.WriteLine("came to if");
                CompletedTransferClient(this, EventArgs.Empty);
            }
        }

        #endregion

        #region properties

        private string serverPort;
        private AcceptListener acceptListener;
        private string outputFolder;
        List<TransferQueue> queueList = new List<TransferQueue>();
        private string audioMessageFolder;

        public bool serverRunning { private set; get; }

        public bool transactionGoing=false;
        #endregion

        #region privateFunctions

        private void transferClient_Stopped_(object sender, TransferQueue queue)
        {
            OnStopedTransferClient(queue);
        }

        private void transferClient_Queued_(object sender, TransferQueue queue)
        {
            transactionGoing = true;
            queueList.Add(queue);

            if (queue.Type == QueueType.Download)
            {
                transferManager.StartTransfer(queue);
            }
            OnQueuedTransferClient(queue);
        }


        private void transferClient_ProgressChanged_(object sender, TransferQueue queue)
        {
            OnChangedProgress(queue);
        }

        private void transferClient_Disconnected_(object sender, EventArgs e)
        {
            OnDisconnectedTransferClient();
            deregisterEvents();
            closeAllQueues();

            transferManager = null;

            if (serverRunning)
            {
                acceptListener.Start(int.Parse(serverPort));
            }
        }

        private void transferClient_Completed_(object sender, TransferQueue queue)
        {
            Console.WriteLine("trans complete in fsc");
            System.Media.SystemSounds.Asterisk.Play();

            transactionGoing = false;

            OnCompletedTransferClient();
        }

        private void transferClient_Completed_2(object sender, TransferQueue queue)
        {
            Console.WriteLine("trans complete in fsc 2");

        }

        public void setDefaultSaveDirectory()
        {
//            outputFolder = "Transfers";
            outputFolder = settings.Default.outputFolder;
            audioMessageFolder = settings.Default.audioInPath;


            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);

            }
            if (!Directory.Exists(audioMessageFolder))
            {
                Directory.CreateDirectory(audioMessageFolder);

            }
        }

        public void setupTempOutputFolder(string tempOutputFolder)
        {
            outputFolder = tempOutputFolder;

            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);

            }
        }

        private void AcceptListenerAccepted(object sender, SocketAcceptedEventArgs e)
        {
//            acceptListener.Stop();

            transferManager = new TransferManager(e.Accepted);
            transferManager.OutputFolder = outputFolder;
            transferManager.audioMessageFolder = audioMessageFolder;
            registerEvents();


            transferManager.Run();


            OnConnected(transferManager.EndPoint.ToString());
        }

        private void connectCallback(object sender, string error)
        {
            if (error != null)
            {
                transferManager.Close();
                transferManager = null;
                MessageBox.Show(error, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            registerEvents();
            transferManager.OutputFolder = outputFolder;
            transferManager.audioMessageFolder = audioMessageFolder;

            transferManager.Run();

            OnConnected(transferManager.EndPoint.Address.ToString()); //firing event connected
        }

        private void registerEvents()
        {
            transferManager.Complete += transferClient_Completed_;
            transferManager.Complete += transferClient_Completed_2;
            transferManager.Disconnected += transferClient_Disconnected_;
            transferManager.ProgressChanged += transferClient_ProgressChanged_;
            transferManager.Queued += transferClient_Queued_;
            transferManager.Stopped += transferClient_Stopped_;
        }


        private void deregisterEvents()
        {
            if (transferManager == null)
                return;

            transferManager.Complete -= transferClient_Completed_;
            transferManager.Complete -= transferClient_Completed_2;
            transferManager.Disconnected -= transferClient_Disconnected_;
            transferManager.ProgressChanged -= transferClient_ProgressChanged_;
            transferManager.Queued -= transferClient_Queued_;
            transferManager.Stopped -= transferClient_Stopped_;
        }

        #endregion

        // functions under this will be used in public

        #region publicFunctions

        public FileShareMiddleController()
        {
            initialize();
        }

        public void initialize()
        {
            acceptListener = new AcceptListener();
            acceptListener.Accepted += AcceptListenerAccepted;
            setDefaultSaveDirectory();
        }

        public TransferManager transferManager { get; private set; }

        public bool hasTransferClientInitialized()
        {
            if (transferManager == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void setOutputFolder(string path)
        {
            outputFolder = path;

            if (transferManager != null)
            {
                transferManager.OutputFolder = outputFolder;
            }
        }

        public bool startServer(string port)
        {
            serverPort = port.Trim();

            if (serverRunning)
                return false;

            serverRunning = true;
            try
            {
                acceptListener.Start(int.Parse(serverPort));

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to listen on port " + port + " \n" + e.Message, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        public bool stopServer()
        {
            if (!serverRunning)
                return false;

            if (transferManager != null)
                transferManager.Close();
            acceptListener.Stop();

            serverRunning = false;
            return true;
        }

        public void connect(string ip, string port)
        {
            if (transferManager == null)
            {
                transferManager = new TransferManager();
                transferManager.Connect(ip.Trim(), int.Parse(port.Trim()),
                    connectCallback);

                //               
            }
        }

        public void disconnect()
        {
            if (transferManager != null)
            {
                transferManager.Close();
                transferManager = null;
            }
        }

        public void connectOrDisconnect(string ip, string port)
        {
            if (transferManager == null)
            {
                transferManager = new TransferManager();
                transferManager.Connect(ip.Trim(), int.Parse(port.Trim()),
                    connectCallback);
            }
            else
            {
                transferManager.Close();
                transferManager = null;
            }
        }

        public bool isTransactionGoing()
        {
            int progressOfRunnigQ = MiddleController.getInstance().fileShareController.getOverallProgress();
            if (progressOfRunnigQ > 0 && progressOfRunnigQ != 100)
            {
                return true;
            }
            return false;
        }

        public int getProgressOf(TransferQueue queue)
        {
            return queue.Progress;
        }

        public int getOverallProgress()
        {
            if (transferManager == null)
            {
                return 0;
            }
            else
            {
                return transferManager.GetOverallProgress();
            }
        }

        public bool isQueueRunninig(TransferQueue queue)
        {
            return queue.Running;
        }

        public bool ChooseAndSendFile()
        {
            if (!hasTransferClientInitialized())
                return false;

            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.Filter = "All Files (*.*)|*.*";
                o.Multiselect = true;

                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in o.FileNames)
                    {
                        sendFile(file);
                    }
                    return true;
                }
            }
            return false;
        }

        public void SendChoosedFiles(OpenFileDialog o)
        {
            if (!hasTransferClientInitialized())
                return;

            foreach (string file in o.FileNames)
            {
                sendFile(file);
            }
        }

        public void SendAudioFiles(string file)
        {
            if (!hasTransferClientInitialized())
                return;

            sendFile(file);
        }


        public void sendFile(String file)
        {
            transferManager.QueueTransfer(file);
        }

        public void stopQueue(TransferQueue queue)
        {
            queue.Client.StopTransfer(queue);
        }

        public void pauseOrStartQueue(TransferQueue queue)
        {
            queue.Client.PauseTransfer(queue);
        }

        public void closeAllQueues()
        {
            foreach (var queue in queueList)
            {
                queue.Close();
            }
        }

        #endregion publicFunctions
    }
}