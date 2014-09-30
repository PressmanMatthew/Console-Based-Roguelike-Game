using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class DarkMagentaPixel : Pixel
    {
        public DarkMagentaPixel()
        {
            this.color = Color.Purple;
            this.colorNum = 8;
            this.consoleColor = ConsoleColor.DarkMagenta;
        }
    }
}
