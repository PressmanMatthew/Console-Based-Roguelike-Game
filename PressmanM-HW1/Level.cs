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
        Bitmap tileMap;
        static Tile tile = new Tile("grasstile.png");
        GrassTile grass = new GrassTile();
        static Tile pondTile = new Tile("pondtile.png");
        ColorHandler colHandler = new ColorHandler();
        static int tileLength =  tile.GetTileLength();
        Color pixel;
        const int levelSize = 50;
        int colorNum;
        int levelPixelsNum = (levelSize * tileLength);
        Color[,] pixels = new Color[tileLength, tileLength];
        public int[,] tiles = new int[levelSize, levelSize];
        int[,] grassPixels = new int[tileLength, tileLength];
        int[,] pondPixels = new int[tileLength, tileLength];

        public Level()
        {

        }

        public Level(String levelFile)
        {
            fullPath = directoryPath + levelFile;
            tileMap = new Bitmap(fullPath);

            for (int i = 0; i < levelSize - 1; i++)
            {
                for (int j = 0; j < levelSize - 1; j++)
                {
                    pixel = tileMap.GetPixel(i, j);
                    colorNum = colHandler.ColorCheck(pixel);

                    tiles[i, j] = colorNum;
                }
            }

            //for (int i = 0; i < tileLength - 1; i++)
            //{
            //    for (int j = 0; j < tileLength - 1; j++)
            //    {
            //        grassPixels[i, j] = tile.GetPixel(i, j);
            //        pondPixels[i, j] = pondTile.GetPixel(i, j);
            //    }
            //}
        }

        public void CreateLevel()
        {
            int orgCursorLeftPos = Console.CursorLeft;
            int orgCursorUpPos = Console.CursorTop;
            for (int i = 0; i < levelPixelsNum; i++)
            {
                for (int j = 0; j < levelPixelsNum; j++)
                {
                    int tilesFinishedi = i / tileLength;
                    int pixelIteri = i - (tilesFinishedi * tileLength);
                    int tilesFinishedj = j / tileLength;
                    int pixelIterj = j - (tilesFinishedj * tileLength);
                    int cursorLeftPos = orgCursorLeftPos + j;
                    int cursorUpPos = orgCursorUpPos + i;
                    //Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                    

                    if (colHandler.GreenColorCheck(tiles[tilesFinishedj, tilesFinishedi]))
                    {
                        //Console.WriteLine(tiles[tilesFinishedj, tilesFinishedi]);
                        pixel = grass.GetPixel(pixelIterj, pixelIteri);
                        pixels[pixelIterj, pixelIteri] = pixel;
                        colorNum = colHandler.ColorCheck(pixel);
                        grassPixels[pixelIterj, pixelIteri] = colorNum;
                        //Console.WriteLine(colorNum);
                        colHandler.ColorCodeReturn(colorNum);
                        //grass.CreateGrassTile();
                        //pixel = tile.GetPixel(pixelIterj, tilesFinishedi);
                        //colorNum = Pixel.ColorCheck(pixel);
                        //Pixel.ColorCodeReturn(colorNum);
                        //for (int x = 0; x < tileLength; x++)
                        //{
                        //    Pixel.ColorCodeReturn(grassTile.GetPixel(x, pixelIteri));
                        //}
                    }
                    else if (colHandler.BlueColorCheck(tiles[tilesFinishedj, tilesFinishedi]))
                    {
                        pixel = pondTile.GetPixel(pixelIterj, pixelIteri);
                        pixels[pixelIterj, pixelIteri] = pixel;
                        colorNum = colHandler.ColorCheck(pixel);
                        pondPixels[pixelIterj, pixelIteri] = colorNum;
                        //Console.WriteLine(colorNum);
                        colHandler.ColorCodeReturn(colorNum);
                    }

                    if (j == levelPixelsNum - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        public void ReplaceTile(int windowLeftPos, int windowUpPos, int moveSpeed)
        {
            int cursorLeftPos = Console.WindowLeft + 20 + (moveSpeed * 4);
            int cursorUpPos = Console.WindowTop + (moveSpeed * 4);
            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            Console.SetWindowPosition(windowLeftPos, windowUpPos);
            if (tiles[(cursorLeftPos / 5), (cursorUpPos / 5)] == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = Pixel.ColorCheck(pondTile.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
            else if (tiles[(cursorLeftPos / 5), (cursorUpPos / 5)] == 12)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = Pixel.ColorCheck(tile.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
        }

        public void ClearScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
