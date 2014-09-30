using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class DarkYellowPixel : Pixel
    {
        public DarkYellowPixel()
        {
            this.color = Color.Olive;
            this.colorNum = 10;
            this.consoleColor = ConsoleColor.DarkYellow;
        }
    }
}
