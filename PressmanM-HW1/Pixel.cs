using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    public class Pixel
    {
        /////////////////
        //Color Checker//
        /////////////////

        public static int ColorCheck(Color color)
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

        public static Boolean BlackColorCheck(int num)
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

        public static Boolean BlueColorCheck(int num)
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

        public static Boolean CyanColorCheck(int num)
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

        public static Boolean DarkBlueColorCheck(int num)
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
        
        public static Boolean DarkCyanColorCheck(int num)
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

        public static Boolean DarkGrayColorCheck(int num)
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

        public static Boolean DarkGreenColorCheck(int num)
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

        public static Boolean DarkMagentaColorCheck(int num)
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

        public static Boolean DarkRedColorCheck(int num)
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

        public static Boolean DarkYellowColorCheck(int num)
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

        public static Boolean GrayColorCheck(int num)
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

        public static Boolean GreenColorCheck(int num)
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

        public static Boolean MagentaColorCheck(int num)
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

        public static Boolean RedColorCheck(int num)
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

        public static Boolean WhiteColorCheck(int num)
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

        public static Boolean YellowColorCheck(int num)
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

        /////////////////////
        //Color Code Return//
        /////////////////////

        public static void ColorCodeReturn(int num)
        {
            switch (num)
            {
                case 0:
                    CyanPixel();
                    break;
                case 1:
                    BlackPixel();
                    break;
                case 2:
                    BluePixel();
                    break;
                case 3:
                    CyanPixel();
                    break;
                case 4:
                    DarkBluePixel();
                    break;
                case 5:
                    DarkCyanPixel();
                    break;
                case 6:
                    DarkGrayPixel();
                    break;
                case 7:
                    DarkGreenPixel();
                    break;
                case 8:
                    DarkMagentaPixel();
                    break;
                case 9:
                    DarkRedPixel();
                    break;
                case 10:
                    DarkYellowPixel();
                    break;
                case 11:
                    GrayPixel();
                    break;
                case 12:
                    GreenPixel();
                    break;
                case 13:
                    MagentaPixel();
                    break;
                case 14:
                    RedPixel();
                    break;
                case 15:
                    WhitePixel();
                    break;
                case 16:
                    YellowPixel();
                    break;

            }
        }

        ////////////////
        //Pixel Colors//
        ////////////////

        static void BlackPixel()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void BluePixel()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void CyanPixel()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkBluePixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkCyanPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkGrayPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkGreenPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkMagentaPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkRedPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkYellowPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void GrayPixel()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void GreenPixel()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void MagentaPixel()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void RedPixel()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void WhitePixel()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void YellowPixel()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        public static void NextLine()
        {
            Console.WriteLine();
        }
    }
}
