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
                    colorNum = Pixel.ColorCheck(pixel);

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

        public void GrassTile()
        {
            String filePath = Environment.CurrentDirectory + @"\..\..\"; //Find the directory with the program and tile in it
            filePath = filePath + "grasstile.png"; //Add the tile picture name
            Bitmap bit = new Bitmap(filePath); //Create a Bitmap of the image
            const int tileLength = 5;
            Color pixel;
            int colorNum;

            //This starts the parsing of the picture pixels into console colors
            for (int i = 0; i < tileLength - 1; i++)
            {
                for (int j = 0; j < tileLength; j++)
                {
                    pixel = bit.GetPixel(i, j); // iterate through the different pixel colors
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
