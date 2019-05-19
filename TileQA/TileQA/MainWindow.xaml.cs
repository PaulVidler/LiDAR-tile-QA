using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TileQA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

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
