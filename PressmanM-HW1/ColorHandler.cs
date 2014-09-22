using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class ColorHandler
    {
        BlackPixel black = new BlackPixel();
        BluePixel blue = new BluePixel();
        ClearPixel clear = new ClearPixel();
        CyanPixel cyan = new CyanPixel();
        DarkBluePixel darkBlue = new DarkBluePixel();
        DarkCyanPixel darkCyan = new DarkCyanPixel();
        DarkGrayPixel darkGray = new DarkGrayPixel();
        DarkGreenPixel darkGreen = new DarkGreenPixel();
        DarkMagentaPixel darkMagenta = new DarkMagentaPixel();
        DarkRedPixel darkRed = new DarkRedPixel();
        DarkYellowPixel darkYellow = new DarkYellowPixel();
        GrayPixel gray = new GrayPixel();
        GreenPixel green = new GreenPixel();
        MagentaPixel magenta = new MagentaPixel();
        RedPixel red = new RedPixel();
        WhitePixel white = new WhitePixel();
        YellowPixel yellow = new YellowPixel();

        public ColorHandler()
        {

        }


        /////////////////////
        //Color Code Return//
        /////////////////////

        public void ColorCodeReturn(int num)
        {
            switch (num)
            {
                case 0:
                    clear.WriteClearPixel();
                    break;
                case 1:
                    black.WritePixel();
                    break;
                case 2:
                    blue.WritePixel();
                    break;
                case 3:
                    cyan.WritePixel();
                    break;
                case 4:
                    darkBlue.WritePixel();
                    break;
                case 5:
                    darkCyan.WritePixel();
                    break;
                case 6:
                    darkGray.WritePixel();
                    break;
                case 7:
                    darkGreen.WritePixel();
                    break;
                case 8:
                    darkMagenta.WritePixel();
                    break;
                case 9:
                    darkRed.WritePixel();
                    break;
                case 10:
                    darkYellow.WritePixel();
                    break;
                case 11:
                    gray.WritePixel();
                    break;
                case 12:
                    green.WritePixel();
                    break;
                case 13:
                    magenta.WritePixel();
                    break;
                case 14:
                    red.WritePixel();
                    break;
                case 15:
                    white.WritePixel();
                    break;
                case 16:
                    yellow.WritePixel();
                    break;

            }
        }

        public void ColorCodeReturn(int cursorLeftPos, int cursorUpPos, int num)
        {
            switch (num)
            {
                case 0:
                    clear.WriteClearPixel();
                    break;
                case 1:
                    black.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 2:
                    blue.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 3:
                    cyan.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 4:
                    darkBlue.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 5:
                    darkCyan.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 6:
                    darkGray.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 7:
                    darkGreen.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 8:
                    darkMagenta.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 9:
                    darkRed.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 10:
                    darkYellow.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 11:
                    gray.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 12:
                    green.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 13:
                    magenta.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 14:
                    red.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 15:
                    white.WritePixel(cursorLeftPos, cursorUpPos);
                    break;
                case 16:
                    yellow.WritePixel(cursorLeftPos, cursorUpPos);
                    break;

            }
        }


        /////////////////
        //Color Checker//
        /////////////////

        public int ColorCheck(Color color)
        {
            if (color.Equals(Color.FromArgb(0, 0, 0)))
            {
                return 1; // Checks for Black
            }
            else if (color.Equals(Color.FromArgb(0, 0, 255)))
            {
                return 2; // Checks for Blue
            }
            else if (color.Equals(Color.FromArgb(0, 255, 255)))
            {
                return 3; // Checks for Cyan
            }
            else if (color.Equals(Color.FromArgb(0, 0, 128)))
            {
                return 4; // Checks for DarkBlue
            }
            else if (color.Equals(Color.FromArgb(0, 128, 128)))
            {
                return 5; // Checks for DarkCyan
            }
            else if (color.Equals(Color.FromArgb(128, 128, 128)))
            {
                return 6; // Checks for DarkGrey
            }
            else if (color.Equals(Color.FromArgb(0, 128, 0)))
            {
                return 7; // Checks for DarkGreen
            }
            else if (color.Equals(Color.FromArgb(128, 0, 128)))
            {
                return 8; // Checks for DarkMagenta
            }
            else if (color.Equals(Color.FromArgb(128, 0, 0)))
            {
                return 9; // Checks for DarkRed
            }
            else if (color.Equals(Color.FromArgb(128, 128, 0)))
            {
                return 10; // Checks for DarkYellow
            }
            else if (color.Equals(Color.FromArgb(192, 192, 192)))
            {
                return 11; // Checks for Gray
            }
            else if (color.Equals(Color.FromArgb(0, 255, 0)))
            {
                return 12; // Checks for Green
            }
            else if (color.Equals(Color.FromArgb(255, 0, 255)))
            {
                return 13; // Checks for Magenta
            }
            else if (color.Equals(Color.FromArgb(255, 0, 0)))
            {
                return 14; // Checks for Red
            }
            else if (color.Equals(Color.FromArgb(255, 255, 255)))
            {
                return 15; // Checks for White
            }
            else if (color.Equals(Color.FromArgb(255, 255, 0)))
            {
                return 16; // Checks for Yellow
            }
            else
            {
                return 0; // Returns the default for none
            }
        }

        ///////////////////////
        //Color Code Checkers//
        ///////////////////////

        public Boolean BlackColorCheck(int num)
        {
            if (num == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean BlueColorCheck(int num)
        {
            if (num == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CyanColorCheck(int num)
        {
            if (num == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DarkBlueColorCheck(int num)
        {
            if (num == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DarkCyanColorCheck(int num)
        {
            if (num == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DarkGrayColorCheck(int num)
        {
            if (num == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DarkGreenColorCheck(int num)
        {
            if (num == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DarkMagentaColorCheck(int num)
        {
            if (num == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DarkRedColorCheck(int num)
        {
            if (num == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DarkYellowColorCheck(int num)
        {
            if (num == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean GrayColorCheck(int num)
        {
            if (num == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean GreenColorCheck(int num)
        {
            if (num == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean MagentaColorCheck(int num)
        {
            if (num == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean RedColorCheck(int num)
        {
            if (num == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean WhiteColorCheck(int num)
        {
            if (num == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean YellowColorCheck(int num)
        {
            if (num == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
