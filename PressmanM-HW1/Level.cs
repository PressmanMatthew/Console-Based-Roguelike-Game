using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class Level
    {
        String directoryPath = Environment.CurrentDirectory + @"\..\..\levels\";
        String fullPath;
        protected string levelFile { get; set;}
        Bitmap tileMap;
        //static Tile tile = new Tile("grasstile.png");
        static GrassTile grass = new GrassTile();
        ColorHandler colHandler = new ColorHandler();
        TileHandler tileHandler = new TileHandler();
        static int tileLength = grass.GetTileLength();
        static int tileHeight = grass.GetTileHeight();
        static int levelSize = 50; // should match the number of pixels in the level file and be divisible by 5
        Color pixel;
        int colorNum;
        int levelVertPixelsNum = (levelSize * tileHeight);
        int levelHorPixelsNum = (levelSize * tileLength);
        public static int[,] tiles = new int[levelSize, levelSize];

        public Level()
        {

        }

        public void ParseBitmap()
        {
            fullPath = directoryPath + levelFile;
            tileMap = new Bitmap(fullPath);

            for (int i = 0; i < levelSize - 1; i++)
            {
                for (int j = 0; j < levelSize - 1; j++)
                {
                    pixel = tileMap.GetPixel(j, i);
                    colorNum = colHandler.ColorCheck(pixel);

                    tiles[j, i] = colorNum;
                }
            }
        }

        public void CreateLevel()
        {
            int orgCursorLeftPos = Console.CursorLeft;
            int orgCursorUpPos = Console.CursorTop;
            for (int i = 0; i < levelVertPixelsNum; i++)
            {
                for (int j = 0; j < levelHorPixelsNum; j++)
                {
                    int tilesFinishedi = i / tileHeight;
                    int pixelIteri = i - (tilesFinishedi * tileHeight);
                    int tilesFinishedj = j / tileLength;
                    int pixelIterj = j - (tilesFinishedj * tileLength);
                    int cursorLeftPos = orgCursorLeftPos + j;
                    int cursorUpPos = orgCursorUpPos + i;
                    //Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                    tileHandler.LevelTileChecker(tiles[tilesFinishedj, tilesFinishedi], pixelIterj, pixelIteri);

                    if (j == levelHorPixelsNum - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        public static int GetTileNum(int x, int y)
        {
            return tiles[x, y];
        }

        public void ClearScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
