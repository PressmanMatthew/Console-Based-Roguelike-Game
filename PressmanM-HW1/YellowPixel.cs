using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class YellowPixel : Pixel
    {
        public YellowPixel()
        {
            this.color = Color.Yellow;
            this.colorNum = 16;
            this.consoleColor = ConsoleColor.Yellow;
        }
    }
}
