using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class DarkGrayPixel : Pixel
    {
        public DarkGrayPixel()
        {
            this.color = Color.Gray;
            this.colorNum = 6;
            this.consoleColor = ConsoleColor.DarkGray;
        }
    }
}
