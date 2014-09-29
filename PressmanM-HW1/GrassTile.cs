using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressmanM_HW1
{
    class GrassTile : Tile
    {
        public GrassTile()
        {
            this.tileFile = "grasstile.png";
            this.ParseBitmap();
        }
    }
}
