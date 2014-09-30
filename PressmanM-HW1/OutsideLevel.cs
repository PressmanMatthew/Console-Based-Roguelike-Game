using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PressmanM_HW1
{
    class OutsideLevel : Level
    {
        String directoryPath = Environment.CurrentDirectory + @"\..\..\levels\";
        String fullPath;
        Bitmap tileMap;
        //static Tile tile = new Tile("grasstile.png");
        static GrassTile grass = new GrassTile();
        HouseRoofTile houseRoof = new HouseRoofTile();
        static Tile pondTile = new Tile("pondtile.png");
        ColorHandler colHandler = new ColorHandler();
        TileHandler tileHandler = new TileHandler();
        static int tileLength =  grass.GetTileLength();
        Color pixel;
        const int levelSize = 50; // should match the number of pixels in the level file and be divisible by 5
        int colorNum;
        int levelPixelsNum = (levelSize * tileLength);
        Color[,] pixels = new Color[tileLength, tileLength];
        int[,] grassPixels = new int[tileLength, tileLength];
        int[,] pondPixels = new int[tileLength, tileLength];

        public OutsideLevel()
        {
            this.levelFile = "outside.png";
            this.ParseBitmap();
        }

        public OutsideLevel(string levelFile)
        {
            this.levelFile = levelFile;
            this.ParseBitmap();
        }
    }
}
