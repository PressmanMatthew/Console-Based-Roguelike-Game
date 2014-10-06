using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PressmanM_HW1
{
    class MovementHandler
    {
        OutsideLevel outsidelvl = new OutsideLevel();
        static GrassTile grass = new GrassTile();
        static PondTile pond = new PondTile();
        static int tileLength = grass.GetTileLength();
        static int tileHeight = grass.GetTileHeight();
        static TileHandler tileHandler = new TileHandler();
        static ColorHandler colHandler = new ColorHandler();
        static int windowPositionLeft = 0;
        static int windowPositionUp = 0;
        static int bufferAdd = Program.bufferAdd;
        static int windowHeight = Program.windowHeight; //70
        static int windowLength = Program.windowLength;

        static int windowTileNumWidth = windowLength / 10;
        public int WindowTileNumWidth
        {
            get
            {
                return windowTileNumWidth;
            }
        }

        static int windowTileNumHeight = windowHeight / 10;
        public int WindowTileNumHeight
        {
            get
            {
                return windowTileNumHeight;
            }
        }

        static int innerTileBorder = tileHeight / 5;
        public int InnerTileBorder //Accessor for innerTileBorder
        {
            get
            {
                return innerTileBorder;
            }
        }

        static int charTilePositionLeft = windowTileNumWidth / 2;
        public int CharTilePositionLeft //Accessor for charTilePositionLeft
        {
            get
            {
                return charTilePositionLeft;
            }
        }
        
        static int charTilePositionUp = windowTileNumHeight / 2;
        public int CharTilePositionUp //Accessor for charTilePositionUp
        {
            get
            {
                return charTilePositionUp;
            }
        }

        static int charPixelPositionLeft = charTilePositionLeft * 10;
        public int CharPixelPositionLeft //Accessor for charPixelPositionLeft
        {
            get
            {
                return charPixelPositionLeft;
            }
        }

        static int charPixelPositionUp = charTilePositionUp * 10;
        public int CharPixelPositionUp //Accessor for charPixelPositionUp
        {
            get
            {
                return charPixelPositionUp;
            }
        }
        static int horMoveSpeed = tileLength;
        static int vertMoveSpeed = tileHeight;
        static int highBound = bufferAdd + tileLength;
        static int lowBound = 0;
        static int cursorLeftPos;
        static int cursorUpPos;
        static int colorNum;

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
            else
            {
                windowPositionLeft = 100;
                Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
            }
        }

    }
}
