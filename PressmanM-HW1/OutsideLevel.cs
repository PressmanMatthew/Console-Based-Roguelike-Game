using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class OutsideLevel : Level
    {

        public OutsideLevel()
        {
            this.levelFile = "outside.png";
            this.ParseBitmap();
        }

        public OutsideLevel(string levelFile)
        {
            this.levelFile = levelFile;
            this.ParseBitmap();
        }
    }
}
