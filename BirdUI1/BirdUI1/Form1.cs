using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdUI1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        /// Dragable tab for form
        private Point MouseDownLocation;

       
        private void topTab_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void topTab_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        /// Dragable tab for form


        private void closePic_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closePic_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        #region 'Resize'

        bool onFullScreen;
        bool maximized;
        bool on_MinimumSize;
        short minimumWidth = 350;
        short minimumHeight = 26;
        short borderSpace = 20;
        short borderDiameter = 3;

        bool onBorderRight;
        bool onBorderLeft;
        bool onBorderTop;
        bool onBorderBottom;
        bool onCornerTopRight;
        bool onCornerTopLeft;
        bool onCornerBottomRight;
        bool onCornerBottomLeft;

        bool movingRight;
        bool movingLeft;
        bool movingTop;
        bool movingBottom;
        bool movingCornerTopRight;
        bool movingCornerTopLeft;
        bool movingCornerBottomRight;
        bool movingCornerBottomLeft;

        private void startResizer()
        {
            if (movingRight)
            {
                this.Width = Cursor.Position.X - this.Location.X;
            }

            else if (movingLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
            }

            else if (movingTop)
            {
                this.Height = ((this.Height + this.Location.Y) - Cursor.Position.Y);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingBottom)
            {
                this.Height = (Cursor.Position.Y - this.Location.Y);
            }

            else if (movingCornerTopRight)
            {
                this.Width = (Cursor.Position.X - this.Location.X);
                this.Height = ((this.Location.Y - Cursor.Position.Y) + this.Height);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingCornerTopLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
                this.Height = ((this.Height + this.Location.Y) - Cursor.Position.Y);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingCornerBottomRight)
            {
                this.Size = new Size(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
            }

            else if (movingCornerBottomLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Height = (Cursor.Position.Y - this.Location.Y);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
            }
        }

        private void stopResizer()
        {
            movingRight = false;
            movingLeft = false;
            movingTop = false;
            movingBottom = false;
            movingCornerTopRight = false;
            movingCornerTopLeft = false;
            movingCornerBottomRight = false;
            movingCornerBottomLeft = false;
            this.Cursor = Cursors.Default;
            System.Threading.Thread.Sleep(300);
            on_MinimumSize = false;
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            startResizer();
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            stopResizer();
        }

        #endregion
    }
}
