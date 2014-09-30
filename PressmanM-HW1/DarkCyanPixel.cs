using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class DarkCyanPixel : Pixel
    {
        public DarkCyanPixel()
        {
            this.color = Color.Teal;
            this.colorNum = 5;
            this.consoleColor = ConsoleColor.DarkCyan;
        }
    }
}
