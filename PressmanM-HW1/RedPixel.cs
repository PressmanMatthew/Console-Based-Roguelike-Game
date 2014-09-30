using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class RedPixel : Pixel
    {
        public RedPixel()
        {
            this.color = Color.Red;
            this.colorNum = 14;
            this.consoleColor = ConsoleColor.Red;
        }
    }
}
