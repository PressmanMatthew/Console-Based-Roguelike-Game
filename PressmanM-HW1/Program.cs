﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace PressmanM_HW1
{
    class Program
    {
        public static int windowHeight = 62; //70
        public static int windowLength = 130;
        public static int bufferAdd = 440;

        static void Main(string[] args)
        {
            String playerName = "Name";
            String direction = "N";
            String play = "N";
            const int stepsNeeded = 16;
            int stepsTaken = 0;
            OutsideLevel outsidelvl = new OutsideLevel();
            MovementHandler mover = new MovementHandler();
            AttackHandler attacker = new AttackHandler();

            GrassTile grass = new GrassTile();
            PondTile pond = new PondTile();
            int tileLength = grass.GetTileLength();
            int tileHeight = grass.GetTileHeight();
            TileHandler tileHandler = new TileHandler();
            ColorHandler colHandler = new ColorHandler();
            int originalBufferWidth = Console.BufferWidth;
            int originalBufferHeight = Console.BufferHeight;
            int windowPositionLeft = 100;
            int windowPositionUp = 100;
            int originalCursorLeftPos;
            int originalCursorUpPos;
            int cursorLeftPos;
            int cursorUpPos;
            int colorNum;
            

            ////////
            //Init//
            ////////

            outsidelvl.ClearScreen();

            Console.BufferHeight += bufferAdd;
            Console.BufferWidth += bufferAdd;

            Console.SetWindowSize(windowLength, windowHeight);

            outsidelvl.CreateLevel();

            //Aesthetic changes before play can begin
            Console.SetWindowPosition(windowPositionLeft, windowPositionUp);
            originalCursorLeftPos = Console.CursorLeft;
            originalCursorUpPos = Console.CursorTop;
            Console.CursorVisible = false;

            //Change cursor position to the top left pixel of the characters position
            cursorLeftPos = Console.WindowLeft + mover.CharPixelPositionLeft;
            cursorUpPos = Console.WindowTop + mover.CharPixelPositionUp;
            Console.SetCursorPosition(cursorLeftPos, cursorUpPos);

            //Draw the character
            for (int i = 0; i < tileHeight; i++)
            {
                for (int j = 0; j < tileLength; j++)
                {
                    colHandler.ColorCodeReturn(cursorLeftPos + j, cursorUpPos + i, 1);
                }
            }

            //Begin playing - loop
            while (true)
            {
                ConsoleKeyInfo inputKey = Console.ReadKey(true); //Take in any key pressed to inputKey

                mover.CheckForMovement(inputKey);
                attacker.CheckForAttack(inputKey);
            }

            //Starting storyline for setting
            Console.WriteLine("This is a rogue-like game made for Game Design and Developement 105");
            Console.WriteLine("Do you want to play?");
            play = Console.ReadLine();
            play = play.Substring(0,1);
            if (play == "Y" | play == "y") {
                goto intro;
            }
            else {
                goto exit;
            }

            intro:
            //User info input
            Console.WriteLine("Enter your character name:");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome to Morthal " + playerName + "! You start out your day walking to class when you notice Orange Hall, where your programming class takes place has been overgrown with trees and hedges. You walk through the only opening in the wall of shrubery.");
            Console.WriteLine("Before you is the black ground of asphalt. It's different from the bricked sidewalk you were just on, and radiates visible heat. Orange Hall is off in the distance and leading to it is this asphalt path.");
            
            steps:
            Console.WriteLine("How many steps would you like to go?");
            direction = Console.ReadLine();
            stepsTaken += Convert.ToInt32(direction);
            if (stepsTaken == stepsNeeded)
            {
                Console.WriteLine("You walk right up to the front of the house ignoring the door and the pathway.");
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.WriteLine("You stare at the wall");
            }
            else if (stepsTaken > stepsNeeded) {
                Console.WriteLine("You walk right up to the front of the houseignoring the door and the pathway, but you keep walking. You take " + (stepsTaken - stepsNeeded) + " steps before standing there, blankly.");
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.WriteLine("You stare at the wall");
            }
            else
            {
                Console.WriteLine("You walk " + stepsTaken + " steps and stop. You see the house " + (stepsNeeded - stepsTaken)  + " steps away.");
                goto steps;
            }
            
            exit:
            Console.WriteLine("Press Enter to Exit...");
            Console.Read();

            //Player inventory(What items have they aquired, How much health do they have)
            //Array holding player position on the grid
            //Array holding the objects present in each square of the grid(if the player tries to enter a square with another object in it, it doesn't work)
            //Array holding different creatures that will help/harm the player(rock with eyes will help, Koy in the Koy pond will trick, Trees will try to capture, Flowers will prick)
            //Interpret user input for looking around(look right - see the information for the square to the right of them, Same with look left. Look up will show them the trees canopy if overhead, or the top of the house if adjacent to it.)
            //Interpret user input for directions N, S, E, W (Change this later to rotate right or left, then move forward, step left, or step right)
            
            ///////////
            //Outside//
            ///////////

            //The door to the house will only open with the handle put back in place
            //The handle can be found under the rock with eyes
            
            /////////
            //House//
            /////////
            
            //Once in the house you can only see 3 squares in, and the rest is darkness(lights are off)
            //The library will have items for magic casting
            //Kitchen will have physical weapons(knifes, spatulas, pans, pot tops as shields)
            //The living room is open, the TV is on, there is a dead body that was watching tv on the couch, and the door to the basement is in the back corner locked
            //One of the bedrooms will have an enemy in it(random which one it is, random which one the door is open to, and random which one has the key to the basement)
            
            ////////////
            //Basement//
            ////////////
            
            //There are no enemies in the first room
            //There is one enemy in the second room
            //There are two enemies in the third room
            //There is one Hard enemy(boss) in the last room

            /////////
            //Goals//
            /////////

            //I could make the enemies random in the basement, however doing this will mean that the difficulty would have to remain not random(first room easiest - fourth room hardest/boss)
            //Descriptions for each square in the grid(Eventual)
        }
    }
}
