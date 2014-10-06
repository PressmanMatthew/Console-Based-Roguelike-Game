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
        protected string tileFile { get; set; }
        protected Bitmap pixelMap { get; set; }
        private string directoryPath = Environment.CurrentDirectory + @"\..\..\tiles\";
        private string fullPath;
        private ColorHandler colHandler = new ColorHandler();
        private const int tileHeight = 10;
        private const int tileLength = 10;
        private Color pixel;
        private int colorNum;
        private int[,] pixelNums = new int[tileLength, tileHeight];

        public Tile()
        {
            
        }

        public Tile(string tileFile)
        {
            fullPath = directoryPath + tileFile;
            pixelMap = new Bitmap(fullPath);

            for (int i = 0; i < tileHeight; i++)
            {
                for (int j = 0; j < tileLength; j++)
                {
                    pixel = pixelMap.GetPixel(j, i);
                    colorNum = colHandler.ColorCheck(pixel);

                    pixelNums[j, i] = colorNum;
                }
            }
        }

        public void ParseBitmap()
        {
            fullPath = directoryPath + this.tileFile;
            pixelMap = new Bitmap(fullPath);

            for (int i = 0; i < tileHeight; i++)
            {
                for (int j = 0; j < tileLength; j++)
                {
                    pixel = pixelMap.GetPixel(j, i);
                    colorNum = colHandler.ColorCheck(pixel);

                    pixelNums[j, i] = colorNum;
                }
            }
        }

        public void CreateTile(int cursorLeftPos, int cursorUpPos)
        {


            //This starts the parsing of the picture pixels into console colors
            for (int i = 0; i < tileHeight - 1; i++)
            {
                for (int j = 0; j < tileLength - 1; j++)
                {
                    pixel = GetPixel(j, i); // iterate through the different pixel colors
                    colorNum = colHandler.ColorCheck(pixel);

                    Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                    colHandler.ColorCodeReturn(colorNum);
                }
            }
        }

        public int GetTileLength()
        {
            return tileLength;
        }

        public int GetTileHeight()
        {
            return tileHeight;
        }

        public Color GetPixel(int x, int y)
        {
            return pixelMap.GetPixel(x, y);
        }

        public void SetPixel(Color color, int x, int y)
        {
            pixelMap.SetPixel(x, y, color);
        }

        public int GetPixelNum(int x, int y)
        {
            return pixelNums[x, y];
        }

        public void SetPixel(int x, int y, int colorNum)
        {
            pixelNums[x, y] = colorNum;
        }
    }
}
