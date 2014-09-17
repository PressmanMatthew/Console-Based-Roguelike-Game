using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PressmanM_HW1;

namespace PressmanM_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            String playerName = "Name";
            String direction = "N";
            String play = "N";
            const int stepsNeeded = 16;
            int stepsTaken = 0;
            Level lvl = new Level("outside.png");

            ////////
            //Init//
            ////////

            ClearScreen();
            lvl.CreateLevel();
            //GrassTile();

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

        static void GrassTile()
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
                    colorNum = ColorCheck(pixel);

                    ColorCode(colorNum);

                    if (j == tileLength - 1)
                    {
                        NextLine(); // Makes a new line at the end of each line
                    }
                } 
            }
        }

        static void ClearScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }

        static int ColorCheck(Color color)
        {
            if (color.Equals(Color.FromArgb(0, 0, 0))) {
                return 1; // Checks for Black
            }
            else if (color.Equals(Color.FromArgb(0, 0, 255))) {
                return 2; // Checks for Blue
            }
            else if (color.Equals(Color.FromArgb(0, 255, 255))) {
                return 3; // Checks for Cyan
            }
            else if (color.Equals(Color.FromArgb(0, 0, 128))) {
                return 4; // Checks for DarkBlue
            }
            else if (color.Equals(Color.FromArgb(0, 128, 128))) {
                return 5; // Checks for DarkCyan
            }
            else if (color.Equals(Color.FromArgb(128, 128, 128))) {
                return 6; // Checks for DarkGrey
            }
            else if (color.Equals(Color.FromArgb(0, 128, 0))) {
                return 7; // Checks for DarkGreen
            }
            else if (color.Equals(Color.FromArgb(128, 0, 128))) {
                return 8; // Checks for DarkMagenta
            }
            else if (color.Equals(Color.FromArgb(128, 0, 0))) {
                return 9; // Checks for DarkRed
            }
            else if (color.Equals(Color.FromArgb(128, 128, 0))) {
                return 10; // Checks for DarkYellow
            }
            else if (color.Equals(Color.FromArgb(192, 192, 192))) {
                return 11; // Checks for Gray
            }
            else if (color.Equals(Color.FromArgb(0, 255, 0))) {
                return 12; // Checks for Green
            }
            else if (color.Equals(Color.FromArgb(255, 0, 255))) {
                return 13; // Checks for Magenta
            }
            else if (color.Equals(Color.FromArgb(255, 0, 0))) {
                return 14; // Checks for Red
            }
            else if (color.Equals(Color.FromArgb(255, 255, 255))) {
                return 15; // Checks for White
            }
            else if (color.Equals(Color.FromArgb(255, 255, 0))) {
                return 16; // Checks for Yellow
            }
            else
            {
                return 0; // Returns the default for none
            }
        }
        static void ColorCode(int num)
        {
            switch (num)
            {
                case 0:
                    NextLine();
                    break;
                case 1:
                    BlackPixel();
                    break;
                case 2:
                    BluePixel();
                    break;
                case 3:
                    CyanPixel();
                    break;
                case 4:
                    DarkBluePixel();
                    break;
                case 5:
                    DarkCyanPixel();
                    break;
                case 6:
                    DarkGrayPixel();
                    break;
                case 7:
                    DarkGreenPixel();
                    break;
                case 8:
                    DarkMagentaPixel();
                    break;
                case 9:
                    DarkRedPixel();
                    break;
                case 10:
                    DarkYellowPixel();
                    break;
                case 11:
                    GrayPixel();
                    break;
                case 12:
                    GreenPixel();
                    break;
                case 13:
                    MagentaPixel();
                    break;
                case 14:
                    RedPixel();
                    break;
                case 15:
                    WhitePixel();
                    break;
                case 16:
                    YellowPixel();
                    break;
                
            }
        }

        static void BlackPixel()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void BluePixel()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void CyanPixel()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkBluePixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkCyanPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkGrayPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkGreenPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkMagentaPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkRedPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DarkYellowPixel()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void GrayPixel()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void GreenPixel()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void MagentaPixel()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void RedPixel()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void WhitePixel()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void YellowPixel()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void NextLine()
        {
            Console.WriteLine();
        }
    }
}
