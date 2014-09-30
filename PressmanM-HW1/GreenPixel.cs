using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class GreenPixel : Pixel
    {
        public GreenPixel()
        {
            this.color = Color.Lime;
            this.colorNum = 12;
            this.consoleColor = ConsoleColor.Green;
        }
    }
}
