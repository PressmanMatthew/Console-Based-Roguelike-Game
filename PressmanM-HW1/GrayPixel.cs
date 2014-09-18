using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class GrayPixel : Pixel
    {
        public GrayPixel()
        {
            this.color = Color.Silver;
            this.colorNum = 11;
            this.consoleColor = ConsoleColor.Gray;
        }
    }
}
