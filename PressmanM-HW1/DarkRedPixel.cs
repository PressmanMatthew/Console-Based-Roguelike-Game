using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class DarkRedPixel : Pixel
    {
        public DarkRedPixel()
        {
            this.color = Color.Maroon;
            this.colorNum = 9;
            this.consoleColor = ConsoleColor.DarkRed;
        }
    }
}
