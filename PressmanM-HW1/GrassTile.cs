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
        Tile grassTile = new Tile("grasstile.png");
        ColorHandler colHandler = new ColorHandler();
        const int tileLength = 5;
        Color pixel;
        int colorNum;

        public GrassTile()
        {

        }

        public void CreateGrassTile()
        {

            int originalCursorLeftPos = Console.CursorLeft;
            int originalCursorUpPos = Console.CursorTop;

            //This starts the parsing of the picture pixels into console colors
            for (int i = 0; i < tileLength - 1; i++)
            {
                for (int j = 0; j < tileLength; j++)
                {
                    pixel = grassTile.GetPixel(i, j); // iterate through the different pixel colors
                    colorNum = colHandler.ColorCheck(pixel);
                    int cursorLeftPos = originalCursorLeftPos + j;
                    int cursorUpPos = originalCursorUpPos + i;

                    colHandler.ColorCodeReturn(cursorLeftPos, cursorUpPos, colorNum);
                }
            }
        }

        public Color GetPixel(int x, int y)
        {
            return grassTile.GetPixel(x, y);
        }

        public void SetPixel(Color color, int x, int y)
        {
            grassTile.SetPixel(color, x, y);
        }
    }
}
