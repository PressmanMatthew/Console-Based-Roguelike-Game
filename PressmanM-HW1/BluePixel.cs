using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class BluePixel : Pixel
    {
        public BluePixel()
        {
            this.color = Color.Blue;
            this.colorNum = 2;
            this.consoleColor = ConsoleColor.Blue;
        }
    }
}
