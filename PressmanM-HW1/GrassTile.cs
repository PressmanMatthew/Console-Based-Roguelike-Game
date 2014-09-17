using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class GrassTile
    {
        public void CreateGrassTile()
        {
            Tile grassTile = new Tile("grasstile.png");
            const int tileLength = 5;
            Color pixel;
            int colorNum;

            //This starts the parsing of the picture pixels into console colors
            for (int i = 0; i < tileLength - 1; i++)
            {
                for (int j = 0; j < tileLength; j++)
                {
                    pixel = grassTile.GetPixel(i, j); // iterate through the different pixel colors
                    colorNum = Pixel.ColorCheck(pixel);


                    Pixel.ColorCodeReturn(colorNum);

                    if (j == tileLength - 1)
                    {
                        Pixel.NextLine(); // Makes a new line at the end of each line
                    }
                }
            }
        }
    }
}
