using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyBird.WinFormUI
{
    public static class AppTheme
    {

        //Chat bubble
        public static Color chatBubbleInColor=Color.DarkGray;
        public static Color chatBubbleOutColor=Color.FromArgb(255, 53, 151, 181);

        public static Color chatBubbleInTextColor=Color.White;
        public static Color chatBubbleOutTextColor=Color.White;

        public static Color chatBubbleInTimeColor=Color.White;
        public static Color chatBubbleOutTimeColor=Color.White;


        //Contacts
        public static Color contactNormalColor=Color.SkyBlue;
        public static Color contactNormalSideColor =Color.FromArgb(255, 53, 151, 181);

        public static Color contactHoverColor =Color.LightBlue;

        public static Color contactSelectedColor =Color.White;
        public static Color contactSelectedSideColor = Color.FromArgb(255, 53, 151, 181);


        //Connect button
        public static Color ButtonNormalColor= Color.FromArgb(255, 53, 151, 181);
        public static Color ButtonHoverColor=Color.LimeGreen;

        //Sever button

        public static Color ServerButtonNormalColor = Color.Gray;
//        public static Color ServerButtonHoverColor = Color.LimeGreen;
        public static Color ServerButtonStopColor = Color.LimeGreen;


    }
}
