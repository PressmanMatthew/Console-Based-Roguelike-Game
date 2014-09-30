using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class DarkGreenPixel : Pixel
    {
        public DarkGreenPixel()
        {
            this.color = Color.Green;
            this.colorNum = 7;
            this.consoleColor = ConsoleColor.DarkGreen;
        }
    }
}
