using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class Tile
    {
        String directoryPath = Environment.CurrentDirectory + @"\..\..\tiles\";
        String fullPath;
        ColorHandler colHandler = new ColorHandler();
        Bitmap pixelMap;
        const int tileLength = 5;
        Color pixel;
        int colorNum;
        String tileName;
        private Color[,] pixels = new Color[tileLength,tileLength];

        public Tile(String tileFile)
        {
            fullPath = directoryPath + tileFile;
            pixelMap = new Bitmap(fullPath);

            for (int i = 0; i < tileLength - 1; i++)
            {
                for (int j = 0; i < tileLength - 1; i++)
                {
                    pixel = pixelMap.GetPixel(j, i);
                    colorNum = colHandler.ColorCheck(pixel);

                    pixels[j, i] = pixel;
                }
            }
        }

        public int GetTileLength()
        {
            return tileLength;
        }

        public Color GetPixel(int x, int y)
        {
            return pixelMap.GetPixel(x, y);
        }

        public void SetPixel(Color color, int x, int y)
        {
            pixels[x, y] = color;
        }
    }
}
