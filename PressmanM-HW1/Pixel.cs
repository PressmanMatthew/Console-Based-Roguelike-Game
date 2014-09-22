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

        protected Color color { get; set;}
        protected int colorNum { get; set; }
        protected ConsoleColor consoleColor { get; set; }

        public Pixel()
        {
            

        }

        public void WritePixel(int cursorLeftPos, int cursorUpPos)
        {
            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            Console.BackgroundColor = consoleColor;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        public void WriteClearPixel()
        {
            if (colorNum == 0)
            {
                //Nothing happens because we want the background(previous pixel written in that space to be shown)
            }
            else
            {
                throw new System.InvalidOperationException("Clear Pixel can only be called by clear pixels");
            }
        }
    }
}
