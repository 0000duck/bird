using System;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using flyBird;
using flyBird;
using flyBird.Audio;
using flyBird.Messages;
using flyBird.WinFormUI;
using Message = flyBird.Messages.Message;

namespace BirdUI1
{
    public delegate void MsgReceivedEventHandler(FileMessageBubble bbl);
    public delegate void AudioMsgReceivedEventHandler(AudioMessageBubble bbl);

    public partial class ChatDisplay : UserControl
    {
        private Image sendHover = flyBird.Properties.Resources.sendG;
        private Image recordHover = flyBird.Properties.Resources.recordG;
        private Image sendFileHover = flyBird.Properties.Resources.addFileG;

        private Image sendNormal = flyBird.Properties.Resources.sendB;
        private Image recordNormal = flyBird.Properties.Resources.recordB;
        private Image sendFileNormal = flyBird.Properties.Resources.addFileB;


     //   private System.Timers.Timer tmr = new System.Timers.Timer();

        public string ipTokenInChat { get; set; }


        //middlecontroller singleton object
        public MiddleController middleController = MiddleController.getInstance();
        private FileShareMiddleController fileShareMiddleController;


        public ChatDisplay(string token, FileShareMiddleController fsmc)
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }

            controlHandler = ControlHandler.getInstance();
            controlMessage = ControlMessage.getInstance();

            ipTokenInChat = token;
            userTokenText.Text = token;

            fileShareMiddleController = fsmc;

            controlHandler.FileComming += OnFileComming;
            controlHandler.FileConfirmed += OnFileConfirmed;
            controlHandler.FileRejected += OnFileRejected;
            controlHandler.AudioComming += OnAudioComming;


            fileShareMiddleController.QueuedTransferClient += onQueued;


        }

        private void OnAudioComming(object sender, ControlCommandOccuredEventArgs e)
        {
            AudioMessageBubble bbl = addReceivedAudioMessageToUI(new AudioMessage() { time = DateTime.Now });
            ShowAudioBubble(bbl);
            middleController.fileShareController.transferManager.isAudioComming = true;
        }
        private void OnFileComming(object sender, ControlCommandOccuredEventArgs e)
        {
            FileMessageBubble bbl = addReceivedFileMessageToUI(new FileMessage() { time = DateTime.Now });
            ShowBubble(bbl);
//            middleController.fileShareController.transferManager.isAudioComming = false;
        }

        private void OnFileRejected(object sender, ControlCommandOccuredEventArgs e)
        {
            tempSelectedFile = null;
        }

        private void OnFileConfirmed(object sender, ControlCommandOccuredEventArgs e)
        {
            addReceivedMessageToUI(new TextMessage() {text = "file confirmed event fired"});
        }

      

        private FileMessageBubble rfbbl;

        private void onQueued(object sender, TransferQueue queue)
        {
            if (queue.Type == QueueType.Download)
            {


            }
        }

        private FileMessageBubble currentRunningBubble;
        private FileMessageBubbleSent currentRunningBubbleSent;



        UserControl bbl_old = new ChatBubble();

        private Message newTempMessage;
        private ControlHandler controlHandler;
        private OpenFileDialog tempSelectedFile;
        private ControlMessage controlMessage;

        private AudioMessageBubble currentRunningAudioBubble;


        delegate void setBubbleCallBack(TextMessage message);

        public void addReceivedMessageToUI(TextMessage message)
        {
            if (InvokeRequired)
            {
                setBubbleCallBack d = new setBubbleCallBack(addReceivedMessageToUI);
                this.Invoke(d, new TextMessage[] {message});
            }
            else
            {
                String time = message.time.ToString("h:mm:ss tt");
                ChatBubble bbl = new ChatBubble(message.text, time, MsgType.IN);


                bbl.Location = refPanel2.Location;
                bbl.Size = refPanel2.Size;
                bbl.Anchor = refPanel2.Anchor;
                bbl.Top = bbl_old.Bottom + 10;
                panel2.Controls.Add(bbl);
                workSpace.Top = bbl.Bottom + 20;
                bbl_old = bbl;
                panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
            }
        }


        public FileMessageBubble addReceivedFileMessageToUI(FileMessage message)
        {
            String time = message.time.ToString("h:mm:ss tt");
            FileMessageBubble bbl = new FileMessageBubble(fileShareMiddleController, time, MsgType.IN);
            currentRunningBubble = bbl;


            bbl.Location = refPanel2.Location;
//            bbl.Width = 375;
//            bbl.Height = 141;
            bbl.Anchor = refPanel2.Anchor;
            bbl.Top = bbl_old.Bottom + 10;

            return bbl;
        }

        private AudioMessageBubble addReceivedAudioMessageToUI(AudioMessage message)
        {
            String time = message.time.ToString("h:mm:ss tt");
            AudioMessageBubble bbl = new AudioMessageBubble(fileShareMiddleController, time, MsgType.IN);
            currentRunningAudioBubble = bbl;


            bbl.Location = refPanel2.Location;
       
            bbl.Anchor = refPanel2.Anchor;
            bbl.Top = bbl_old.Bottom + 10;

            return bbl;
        }

        public void addSentMessageToUI(TextMessage message)
        {
            String time = message.time.ToString("h:mm:ss tt");


            ChatBubble bbl = new ChatBubble(message.text, time, MsgType.OUT);


            bbl.Location = refPanel1.Location;
            bbl.Size = refPanel1.Size;
            bbl.Anchor = refPanel1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);
            workSpace.Top = bbl.Bottom + 20;
            bbl_old = bbl;
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;


            sendingTextBox.Text = "";
            sendingTextBox.Select(0, 0);
        }

        public FileMessageBubbleSent addSentFileMessageToUI(FileMessage message)
        {
            String time = message.time.ToString("h:mm:ss tt");


            FileMessageBubbleSent bbl = new FileMessageBubbleSent(fileShareMiddleController, time, MsgType.OUT);
            currentRunningBubbleSent = bbl;

            bbl.Location = refPanel1.Location;
//            bbl.Width = 375;
//            bbl.Height = 134;
            bbl.Anchor = refPanel1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;

            return bbl;
        }

        public void ShowBubble(FileMessageBubble bbl)
        {
            if (InvokeRequired)
            {
                Invoke(new MsgReceivedEventHandler(ShowBubble), bbl);
                return;
            }

            panel2.Controls.Add(bbl);
            workSpace.Top = bbl.Bottom + 20;
            bbl_old = bbl;
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
        }

        public void ShowAudioBubble(AudioMessageBubble bbl)
        {
            if (InvokeRequired)
            {
                Invoke(new AudioMsgReceivedEventHandler(ShowAudioBubble), bbl);
                return;
            }

            panel2.Controls.Add(bbl);
            workSpace.Top = bbl.Bottom + 20;
            bbl_old = bbl;
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
        }

        public void ShowBubbleSent(FileMessageBubbleSent bbl)
        {
            if (InvokeRequired)
            {
                Invoke(new MsgReceivedEventHandler(ShowBubble), bbl);
                return;
            }

            panel2.Controls.Add(bbl);
            workSpace.Top = bbl.Bottom + 20;
            bbl_old = bbl;
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
        }

        private void sendPicButton_Click(object sender, EventArgs e)
        {
            string text_ = sendingTextBox.Text;
            if (text_ != "")
            {
                var msg = new TextMessage() {text = text_, time = DateTime.Now};

                addSentMessageToUI(msg);

                middleController.sendText(text_, ipTokenInChat);
            }
        }

        private void sendingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)
            {
                //for new line (auto, no neeed code)
                //no code here 
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sendPicButton_Click(sender, e);
            }
        }

        private void BtnHover(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox) sender;
            pb.Image = null;
            switch (pb.Name)
            {
                case "sendBtn":
                    pb.Image = sendHover;
                    break;
                case "sendFileBtn":

                    pb.Image = sendFileHover;
                    break;
                case "recordBtn":
                    pb.Image = recordHover;
                    break;
            }
        }

        private void BtnHover_Left(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox) sender;
            pb.Image = null;
            switch (pb.Name)
            {
                case "sendBtn":
                    pb.Image = sendNormal;
                    break;
                case "sendFileBtn":

                    pb.Image = sendFileNormal;
                    break;
                case "recordBtn":
                    pb.Image = recordNormal;
                    break;
            }
        }

        private void sendFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.Filter = "All Files (*.*)|*.*";
                o.Multiselect = true;

                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tempSelectedFile = o;

                    controlMessage.sendFileCommingSignal(ipTokenInChat);

                    sendTempFile();
                }
            }
        }
        private void sendTempFile()
        {
            FileMessageBubbleSent bbl = addSentFileMessageToUI(new FileMessage() {time = DateTime.Now});
            //
            Thread.Sleep(400);
            middleController.fileShareController.SendChoosedFiles(tempSelectedFile);
            ShowBubbleSent(bbl);
        }


        public void OnAudioSendButtonClicked(string file)
        {


            controlMessage.sendAudioCommingSignal(ipTokenInChat);
            //            Thread.Sleep(500);
            Thread.Sleep(400);
            AudioMessageBubble bbl = addSentAudioMessageToUI(new AudioMessage());
            middleController.fileShareController.SendAudioFiles(file);
            ShowAudioBubble(bbl);
        }

        private AudioMessageBubble addSentAudioMessageToUI(AudioMessage message)
        {
            String time = message.time.ToString("h:mm:ss tt");


            AudioMessageBubble bbl = new AudioMessageBubble(fileShareMiddleController, time, MsgType.OUT);
            currentRunningAudioBubble = bbl;

            bbl.Location = refPanel1.Location;
 
            bbl.Anchor = refPanel1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;

            return bbl;
        }


        private void pictureBox1_Click(object sender, EventArgs e) //fileSendTest
        {
            addSentFileMessageToUI(new FileMessage());
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            new AudioRecorder(this).Visible = true;
        }
    }
}