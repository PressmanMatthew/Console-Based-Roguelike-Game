using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class TileHandler
    {
        ColorHandler colHandler = new ColorHandler();

        //Adding a new tile: 
            //Create the object
            //Add it's corresponding color code for level files to TileCheck
            //The Color returned by ColorHandler in the ColorCheck for the tiles[] in each level must equal the number it is assigned here
        GrassTile grass = new GrassTile();
        PondTile pond = new PondTile();
        HouseRoofTile houseRoof = new HouseRoofTile();
        int colorNum;

        public TileHandler()
        {
            
        }

        public void LevelTileChecker(int tileIndexNum, int x, int y)
        {
            switch (tileIndexNum)
            {
                case 1:
                    break;
                case 2: //Case for the pond tile
                    colorNum = pond.GetPixelNum(x, y);
                    colHandler.ColorCodeReturn(colorNum);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9: //Case for the grass tile
                    colorNum = houseRoof.GetPixelNum(x, y);
                    colHandler.ColorCodeReturn(colorNum);
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12: //Case for the house roof tile
                    colorNum = grass.GetPixelNum(x, y);
                    colHandler.ColorCodeReturn(colorNum);
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
            }
        }

        public void ReplaceTile(int windowLeftPos, int windowUpPos, int moveSpeed)
        {
            int cursorLeftPos = Console.WindowLeft + 20 + 20;
            int cursorUpPos = Console.WindowTop + 20;
            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            Console.SetWindowPosition(windowLeftPos, windowUpPos);
            int tileHeight = grass.GetTileHeight();
            int tileLength = grass.GetTileLength();
            if (OutsideLevel.GetTileNum((cursorLeftPos / tileLength), (cursorUpPos / tileHeight)) == 2)
            {
                for (int i = 0; i < tileHeight; i++)
                {
                    for (int j = 0; j < tileLength; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = colHandler.ColorCheck(pond.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
            else if (OutsideLevel.GetTileNum((cursorLeftPos / tileLength), (cursorUpPos / tileHeight)) == 12)
            {
                for (int i = 0; i < tileHeight; i++)
                {
                    for (int j = 0; j < tileLength; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = colHandler.ColorCheck(grass.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
            else if (OutsideLevel.GetTileNum((cursorLeftPos / tileLength), (cursorUpPos / tileHeight)) == 9)
            {
                for (int i = 0; i < tileHeight; i++)
                {
                    for (int j = 0; j < tileLength; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = colHandler.ColorCheck(houseRoof.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
        }

        public void ReplaceTile(int windowLeftPos, int windowUpPos, int moveSpeed, int charPixelPositionLeft, int charPixelPositionUp)
        {
            int cursorLeftPos = Console.WindowLeft + charPixelPositionLeft;
            int cursorUpPos = Console.WindowTop + charPixelPositionUp;
            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            Console.SetWindowPosition(windowLeftPos, windowUpPos);
            int tileHeight = grass.GetTileHeight();
            int tileLength = grass.GetTileLength();
            if (OutsideLevel.GetTileNum((cursorLeftPos / tileLength), (cursorUpPos / tileHeight)) == 2)
            {
                for (int i = 0; i < tileHeight; i++)
                {
                    for (int j = 0; j < tileLength; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = colHandler.ColorCheck(pond.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
            else if (OutsideLevel.GetTileNum((cursorLeftPos / tileLength), (cursorUpPos / tileHeight)) == 12)
            {
                for (int i = 0; i < tileHeight; i++)
                {
                    for (int j = 0; j < tileLength; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = colHandler.ColorCheck(grass.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
            else if (OutsideLevel.GetTileNum((cursorLeftPos / tileLength), (cursorUpPos / tileHeight)) == 9)
            {
                for (int i = 0; i < tileHeight; i++)
                {
                    for (int j = 0; j < tileLength; j++)
                    {
                        Console.SetCursorPosition(cursorLeftPos + j, cursorUpPos + i);
                        colorNum = colHandler.ColorCheck(houseRoof.GetPixel(j, i));
                        colHandler.ColorCodeReturn(colorNum);
                    }
                }
                Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
            }
        }
    }
}
