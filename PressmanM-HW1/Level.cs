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
        static GrassTile grass = new GrassTile();
        static Tile pondTile = new Tile("redtile.png");
        static int tileLength =  tile.GetTileLength();
        Color pixel;
        const int levelSize = 5;
        int colorNum;
        int levelPixelsNum = (levelSize - 1) * (tileLength - 1);
        int[,] tiles = new int[levelSize, levelSize];
        int[,] grassPixels = new int[tileLength, tileLength];
        int[,] pondPixels = new int[tileLength, tileLength];

        public Level(String levelFile)
        {
            fullPath = directoryPath + levelFile;
            tileMap = new Bitmap(fullPath);

            for (int i = 0; i < levelSize - 1; i++)
            {
                for (int j = 0; j < levelSize - 1; j++)
                {
                    pixel = tileMap.GetPixel(i, j);
                    colorNum = Pixel.ColorCheck(pixel);

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
            for (int i = 0; i < levelPixelsNum; i++)
            {
                for (int j = 0; j < levelPixelsNum; j++)
                {
                    int tilesFinishedi = i / 5;
                    int pixelIteri = i - (tilesFinishedi * 5);
                    int tilesFinishedj = j / 5;
                    int pixelIterj = j - (tilesFinishedj * 5);

                    if (Pixel.GreenColorCheck(tiles[tilesFinishedj, tilesFinishedi]))
                    {
                        grass.CreateGrassTile();
                        //for (int x = 0; x < tileLength; x++)
                        //{
                        //    Pixel.ColorCodeReturn(grassTile.GetPixel(x, pixelIteri));
                        //}
                    }
                    else if (Pixel.RedColorCheck(tiles[tilesFinishedj, tilesFinishedi]))
                    {
                        for (int x = 0; x < tileLength; x++)
                        {
                            Pixel.ColorCodeReturn(pondPixels[x, pixelIteri]);
                        }
                    }

                    if (j == levelPixelsNum - 1)
                    {
                        Pixel.NextLine();
                    }
                }
            }
        }
    }
}
