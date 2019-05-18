using System;
using System.IO;
using System.Collections.Generic;

namespace TileQA
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = File.ReadLines(@"C:\Users\Paul\Desktop\tile.txt");

            QAProject project = new QAProject();

            foreach (var line in lines)
            {
                Tile newTile = new Tile();
                newTile.TileName = line;
                newTile.TileSideLength = 500;
                
                Console.WriteLine("Line: " + line);
                Console.WriteLine("Tile name : " + newTile.TileName);
                Console.WriteLine("Tile colour: " + newTile.TileColour);
                Console.WriteLine("State of tile: " + newTile.ThisTileState);
                Console.WriteLine("Metres squared: " + newTile.TileSideLength);
                Console.WriteLine(newTile);
                Console.WriteLine(project.ProjectComplete);


                project.ProjectTiles.Add(newTile);
                
            }

            




        }
    }

    

}
