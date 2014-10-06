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
            this.tileFile = "GrassTile10x10.png";
            //this.tileFile = "GrassTile10x5.png";
            //this.tileFile = "grasstile.png";
            this.ParseBitmap();
        }
    }
}
