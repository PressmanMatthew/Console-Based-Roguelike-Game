using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class BlackPixel : Pixel
    {
        public BlackPixel()
        {
            this.color = Color.Black;
            this.colorNum = 1;
            this.consoleColor = ConsoleColor.Black;
        }
    }
}
