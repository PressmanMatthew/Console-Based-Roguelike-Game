using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressmanM_HW1
{
    class MovementHandler
    {

        public MovementHandler()
        {

        }

        public void CheckForMovement(ConsoleKeyInfo inputKey)
        {
            //Change cursor position to the top left pixel of the characters position
            cursorLeftPos = Console.WindowLeft + charPixelPositionLeft;
            cursorUpPos = Console.WindowTop + charPixelPositionUp;
            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

            //Detect if movement is being attempted
            if (inputKey.Key == ConsoleKey.A | inputKey.Key == ConsoleKey.D | inputKey.Key == ConsoleKey.W | inputKey.Key == ConsoleKey.S)
            {

                switch (inputKey.Key)
                {
                    case ConsoleKey.A:
                        if ((windowPositionLeft - (horMoveSpeed)) < lowBound)
                        {

                        }
                        else
                        {
                            tileHandler.ReplaceTile(windowPositionLeft, windowPositionUp, horMoveSpeed, charPixelPositionLeft, charPixelPositionUp);
                            cursorLeftPos = Console.WindowLeft + charPixelPositionLeft - tileLength;
                            cursorUpPos = Console.WindowTop + charPixelPositionUp;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
                            for (int i = 0; i < tileHeight; i++)
                            {
                                for (int j = 0; j < tileLength; j++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + j, cursorUpPos + i, 1);
                                }
                            }
                            Thread.Sleep(100);
                            windowPositionLeft -= horMoveSpeed;
                            Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
                        }
                        break;
                    case ConsoleKey.D:
                        if ((windowPositionLeft + (horMoveSpeed)) > highBound - 45)
                        {

                        }
                        else
                        {
                            tileHandler.ReplaceTile(windowPositionLeft, windowPositionUp, horMoveSpeed, charPixelPositionLeft, charPixelPositionUp);
                            Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
                            cursorLeftPos = Console.WindowLeft + charPixelPositionLeft + horMoveSpeed;
                            cursorUpPos = Console.WindowTop + charPixelPositionUp;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
                            for (int i = 0; i < tileHeight; i++)
                            {
                                for (int j = 0; j < tileLength; j++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + j, cursorUpPos + i, 1);
                                }
                            }
                            Thread.Sleep(100);
                            windowPositionLeft += horMoveSpeed;
                            Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
                        }
                        break;
                    case ConsoleKey.W:
                        if ((windowPositionUp - (vertMoveSpeed * 2)) < lowBound)
                        {

                        }
                        else
                        {
                            tileHandler.ReplaceTile(windowPositionLeft, windowPositionUp, vertMoveSpeed, charPixelPositionLeft, charPixelPositionUp);
                            cursorLeftPos = Console.WindowLeft + charPixelPositionLeft;
                            cursorUpPos = Console.WindowTop + charPixelPositionUp - tileHeight;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
                            for (int i = 0; i < tileHeight; i++)
                            {
                                for (int j = 0; j < tileLength; j++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + j, cursorUpPos + i, 1);
                                }
                            }
                            Thread.Sleep(100);
                            windowPositionUp -= vertMoveSpeed;
                            Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
                        }
                        break;
                    case ConsoleKey.S:
                        if ((windowPositionUp + (vertMoveSpeed * 2)) > highBound)
                        {

                        }
                        else
                        {
                            tileHandler.ReplaceTile(windowPositionLeft, windowPositionUp, vertMoveSpeed, charPixelPositionLeft, charPixelPositionUp);
                            cursorLeftPos = Console.WindowLeft + charPixelPositionLeft;
                            cursorUpPos = Console.WindowTop + charPixelPositionLeft + tileHeight;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
                            for (int i = 0; i < tileHeight; i++)
                            {
                                for (int j = 0; j < tileLength; j++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + j, cursorUpPos + i, 1);
                                }
                            }
                            Thread.Sleep(100);
                            windowPositionUp += vertMoveSpeed;
                            Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
                        }
                        break;
                }
            }

            else if (inputKey.Key == ConsoleKey.D1 | inputKey.Key == ConsoleKey.D2)
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
                        cursorLeftPos = Console.WindowLeft + charPixelPositionLeft + innerTileBorder;
                        cursorUpPos = Console.WindowTop + charPixelPositionUp - tileHeight + innerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorUpPos = Console.WindowTop + charPixelPositionUp - ((i + 1) * tileHeight) + innerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            //cursorLeftPos = Console.WindowLeft + charPixelPositionLeft;
                            //cursorUpPos = Console.WindowTop + charPixelPositionLeft + tileHeight;
                            //Console.SetCursorPosition(cursorLeftPos, cursorUpPos);
                            //tileHandler.ReplaceTile(windowPositionLeft, windowPositionUp, vertMoveSpeed, charPixelPositionLeft, charPixelPositionUp - ((10 * (i + 1)) + innerTileBorder - 1));
                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / tileHeight), (cursorUpPos / tileHeight)] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / tileHeight), (cursorUpPos / tileHeight)] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:

                        //Change the cursor position to get ready to draw an attack
                        cursorLeftPos = Console.WindowLeft + charPixelPositionLeft + innerTileBorder;
                        cursorUpPos = Console.WindowTop + charPixelPositionUp + tileHeight + innerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorUpPos = Console.WindowTop + charPixelPositionUp + ((i + 1) * tileHeight) + innerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / tileHeight), (cursorUpPos / tileHeight)] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / tileHeight), (cursorUpPos / tileHeight)] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                    case ConsoleKey.LeftArrow:

                        //Change the cursor position to get ready to draw an attack
                        cursorLeftPos = Console.WindowLeft + charPixelPositionLeft - tileLength + innerTileBorder;
                        cursorUpPos = Console.WindowTop + charPixelPositionUp + innerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorLeftPos = Console.WindowLeft + charPixelPositionLeft - ((i + 1) * tileLength) + innerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / tileLength), (cursorUpPos / tileLength)] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / tileLength), (cursorUpPos / tileLength)] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                    case ConsoleKey.RightArrow:

                        //Change the cursor position to get ready to draw an attack
                        cursorLeftPos = Console.WindowLeft + charPixelPositionLeft + tileLength + innerTileBorder;
                        cursorUpPos = Console.WindowTop + charPixelPositionUp + innerTileBorder;
                        Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                        //iterate through drawing the attack and then drawing over the previous attack
                        for (int i = 0; i < attackRange; i++)
                        {
                            //move the cursor to the next tile to draw on
                            cursorLeftPos = Console.WindowLeft + charPixelPositionLeft + ((i + 1) * tileLength) + innerTileBorder;
                            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, 13);
                                }
                            }

                            Thread.Sleep(attackSpeed);

                            for (int j = 0; j < (innerTileBorder * 2); j++)
                            {
                                for (int k = 0; k < (innerTileBorder * 3); k++)
                                {
                                    if (OutsideLevel.tiles[(cursorLeftPos / tileLength), (cursorUpPos / tileLength)] == 2)
                                    {
                                        colorNum = colHandler.ColorCheck(pond.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else if (OutsideLevel.tiles[(cursorLeftPos / tileLength), (cursorUpPos / tileLength)] == 12)
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    else
                                    {
                                        colorNum = colHandler.ColorCheck(grass.GetPixel(k + innerTileBorder, j + innerTileBorder));
                                    }
                                    colHandler.ColorCodeReturn(cursorLeftPos + k, cursorUpPos + j, colorNum);
                                }

                            }
                        }
                        break;
                }
            }
            else
            {
                windowPositionLeft = 100;
                Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
            }
        }

    }
}
