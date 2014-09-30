using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressmanM_HW1
{
    class HouseRoofTile : Tile
    {
        public HouseRoofTile()
        {
            this.tileFile = "houserooftile.png";
            this.ParseBitmap();
        }

    }
}
