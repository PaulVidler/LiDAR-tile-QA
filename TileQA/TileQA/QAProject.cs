using System;
using System.Collections.Generic;
using System.Text;
using TileQA;

namespace TileQA
{
    class QAProject
    {

        public bool ProjectComplete { get; set; } = false;
        public int TileCount { get; set; }
        public List<Tile> ProjectTiles { get; set; }

        // method to access/change tiles properties

        public void IsComplete()
        {
            int tileCounter = 0;

            foreach (var tile in ProjectTiles)
            {
                if (tile.ThisTileState == TileState.checkedOK)
                {
                    tileCounter += 1;
                }

                else
                {
                    break;
                }
            }

            if (tileCounter == TileCount)
            {
                ProjectComplete = true;
            }
            else
            {
                ProjectComplete = false;
            }

        }


    }
}
