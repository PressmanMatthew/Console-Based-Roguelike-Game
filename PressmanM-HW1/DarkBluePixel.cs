using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class DarkBluePixel : Pixel
    {
        public DarkBluePixel()
        {
            this.color = Color.Navy;
            this.colorNum = 4;
            this.consoleColor = ConsoleColor.DarkBlue;
        }
    }
}
