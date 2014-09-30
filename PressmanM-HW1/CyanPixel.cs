using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class CyanPixel : Pixel
    {
        public CyanPixel()
        {
            this.color = Color.Aqua;
            this.colorNum = 3;
            this.consoleColor = ConsoleColor.Cyan;
        }
    }
}
