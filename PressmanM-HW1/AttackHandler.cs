using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PressmanM_HW1
{
    class AttackHandler
    {
        static MovementHandler mover = new MovementHandler();
        static ColorHandler colHandler = new ColorHandler();
        static GrassTile grass = new GrassTile();
        static PondTile pond = new PondTile();
        static int colorNum;
        static int attackSpeed = 250;
        static int attackRange = 3;
        static int cursorLeftPos;
        static int cursorUpPos;

        public AttackHandler()
        {

        }

        public void CheckForAttack(ConsoleKeyInfo inputKey) 
        {
            //Change cursor position to the top left pixel of the characters position
            //cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft;
            //cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp;
            //Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

            if (inputKey.Key == ConsoleKey.D1 | inputKey.Key == ConsoleKey.D2)
            {
                switch (inputKey.Key)
                {
                    case ConsoleKey.D1:
                        attackSpeed += 25;
                        break;
                    case ConsoleKey.D2:
                        attackSpeed -= 25;
                        break;
                }
            }
            else if (inputKey.Key == ConsoleKey.LeftArrow | inputKey.Key == ConsoleKey.RightArrow | inputKey.Key == ConsoleKey.UpArrow | inputKey.Key == ConsoleKey.DownArrow)
            {
                switch (inputKey.Key)
                {
                    case ConsoleKey.UpArrow:

                        //Change the cursor position to get ready to draw an attack
                        cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft + mover.InnerTileBorder;
                        cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp - grass.GetTileHeight() + mover.InnerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp - ((i + 1) * grass.GetTileHeight()) + mover.InnerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            //cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft;
                            //cursorUpPos = Console.WindowTop + mover.CharPixelPositionLeft + grass.GetTileHeight();
                            //Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
                            //tileHandler.ReplaceTile(windowPositionLeft, windowPositionUp, vertMoveSpeed, mover.CharPixelPositionLeft, mover.CharPixelPositionUp - ((10 * (i + 1)) + mover.InnerTileBorder - 1));
                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileHeight()), (cursorUpPos / grass.GetTileHeight())] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileHeight()), (cursorUpPos / grass.GetTileHeight())] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:

                        //Change the cursor position to get ready to draw an attack
                        cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft + mover.InnerTileBorder;
                        cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp + grass.GetTileHeight() + mover.InnerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp + ((i + 1) * grass.GetTileHeight()) + mover.InnerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileHeight()), (cursorUpPos / grass.GetTileHeight())] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileHeight()), (cursorUpPos / grass.GetTileHeight())] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                    case ConsoleKey.LeftArrow:

                        //Change the cursor position to get ready to draw an attack
                        cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft - grass.GetTileLength() + mover.InnerTileBorder;
                        cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp + mover.InnerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft - ((i + 1) * grass.GetTileLength()) + mover.InnerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileLength()), (cursorUpPos / grass.GetTileLength())] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileLength()), (cursorUpPos / grass.GetTileLength())] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                    case ConsoleKey.RightArrow:

                        //Change the cursor position to get ready to draw an attack
                        cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft + grass.GetTileLength() + mover.InnerTileBorder;
                        cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp + mover.InnerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft + ((i + 1) * grass.GetTileLength()) + mover.InnerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            for (int j = 0; j < (mover.InnerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (mover.InnerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileLength()), (cursorUpPos / grass.GetTileLength())] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / grass.GetTileLength()), (cursorUpPos / grass.GetTileLength())] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + mover.InnerTileBorder, j + mover.InnerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                }
            }
        }
    }
}
