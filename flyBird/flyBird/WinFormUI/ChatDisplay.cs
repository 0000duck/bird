using System;
using System.Drawing;
using System.Windows.Forms;
using flyBird;
using flyBird.Messages;
using Message = flyBird.Messages.Message;

namespace BirdUI1
{
    public partial class ChatDisplay : UserControl
    {
        private Image sendHover = Image.FromFile(@"..\..\WinFormUI\images\sendG.png");
        private Image recordHover = Image.FromFile(@"..\..\WinFormUI\images\recordG.png");
        private Image sendFileHover = Image.FromFile(@"..\..\WinFormUI\images\addFileG.png");

        private Image sendNormal = Image.FromFile(@"..\..\WinFormUI\images\sendB.png");
        private Image recordNormal = Image.FromFile(@"..\..\WinFormUI\images\recordB.png");
        private Image sendFileNormal = Image.FromFile(@"..\..\WinFormUI\images\addFileB.png");


        public string ipTokenInChat { get; set; }


        //middlecontroller singleton object
        public MiddleController middleController = MiddleController.getInstance();

        public ChatDisplay(string token)
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
            ipTokenInChat = token;
            userTokenText.Text = token;
        }


        ChatBubble bbl_old = new ChatBubble();

        private Message newTempMessage;


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
                ChatBubble bbl = new ChatBubble(message.text, time, ChatBubble.msgType.IN);


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


        public void addSentMessageToUI(TextMessage message)
        {
            String time = message.time.ToString("h:mm:ss tt");


            ChatBubble bbl = new ChatBubble(message.text, time, ChatBubble.msgType.OUT);

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


        private void sendPicButton_Click(object sender, EventArgs e)
        {
            string text_ = sendingTextBox.Text;
            if (text_ != "")
            {
                var msg = new TextMessage(){text = text_};

                addSentMessageToUI(msg);

                middleController.sendText(text_,ipTokenInChat);

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
    }
}