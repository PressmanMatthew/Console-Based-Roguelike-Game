using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class MagentaPixel : Pixel
    {
        public MagentaPixel()
        {
            this.color = Color.Magenta;
            this.colorNum = 13;
            this.consoleColor = ConsoleColor.Magenta;
        }
    }
}
