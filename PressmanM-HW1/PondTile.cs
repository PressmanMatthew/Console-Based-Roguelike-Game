using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressmanM_HW1
{
    class PondTile : Tile
    {
        public PondTile()
        {
            this.tileFile = "PondTile10x10.png";
            //this.tileFile = "PondTile10x5.png";
            //this.tileFile = "pondtile.png";
            this.ParseBitmap();
        }

    }
}
