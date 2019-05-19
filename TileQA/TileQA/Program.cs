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

            var size = 500;

            QAProject project = new QAProject();

            foreach (var line in lines)
            {
                Tile newTile = new Tile();
                newTile.TileName = line;
                newTile.TileSideLength = size;
                project.ProjectTiles.Add(newTile);
                
            }

            foreach (var item in project.ProjectTiles)
            {
                Console.WriteLine(item.TileName);
            }

            

        }
    }

    

}
