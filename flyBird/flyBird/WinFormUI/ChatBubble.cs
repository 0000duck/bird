using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using flyBird.WinFormUI;
using flyBird.Messages;

namespace flyBird
{
    public partial class ChatBubble : UserControl
    {
        public ChatBubble()
        {
            InitializeComponent();
        }
        private Color inMsgColor = AppTheme.chatBubbleInColor;
        private Color outMsgColor = AppTheme.chatBubbleOutColor;

        private Color inMsgTextColor = AppTheme.chatBubbleInTextColor;
        private Color outMsgTextColor = AppTheme.chatBubbleOutTextColor;

        private Color inMsgTimeColor = AppTheme.chatBubbleInTimeColor;
        private Color outMsgTimeColor = AppTheme.chatBubbleOutTimeColor;
        public ChatBubble(string message, string time, MsgType messageType)
        {
            InitializeComponent();
            bubbleText.Text = message;
            bubbleTime.Text = time;

       

            if (messageType.ToString() == "IN")
            {
                //incomming Message 
                this.BackColor = inMsgColor;
                this.bubbleText.ForeColor = inMsgTextColor;
                this.bubbleTime.ForeColor = inMsgTimeColor;
            }
            else
            {
                //outGoing
                this.BackColor = outMsgColor;
                this.bubbleText.ForeColor = outMsgTextColor;
                this.bubbleTime.ForeColor = outMsgTimeColor;
            }
            setHeight();
        }

        void setHeight()
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(bubbleText.Text, bubbleText.Font, bubbleText.Width);

            bubbleText.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            bubbleTime.Top = bubbleText.Bottom +5;
            this.Height = bubbleTime.Bottom ;
        }

        private void chatBubble_Resize(object sender, EventArgs e)
        {
            setHeight();
        }


        //label changing function



    }

        
    }
