using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class WhitePixel : Pixel
    {
        public WhitePixel()
        {
            this.color = Color.White;
            this.colorNum = 1;
            this.consoleColor = ConsoleColor.White;
        }
    }
}
