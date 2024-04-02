using Microsoft.Win32;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bingo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int NUM_SQUARES = 25;
        private static Random rnd = new Random();
        private List<string> tile_names = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            ReadBingoTitles();
            if (tile_names != null)
            {
                GenerateBoard();
            }
        }

        private void TileButton_Click(object sender, RoutedEventArgs e)
        {
            Button button  = (Button)sender;
            button.Background = Brushes.Green;
            button.IsEnabled = false;

            // Check for Bingo
            if (CheckRows())
            {
                MessageBox.Show("");
            }

            if (CheckCols())
            {
                MessageBox.Show("");
            }

            if (CheckDiag())
            {
                MessageBox.Show("");
            }
        }

        private void ReadBingoTitles()
        {
            tile_names = null;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select a .txt file with bingo names",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };
            if (ofd.ShowDialog() == true)   // == true......
            {
                try
                {
                    tile_names = File.ReadAllLines(ofd.FileName).ToList();
                } catch {
                    MessageBox.Show("ERROR - failed to read in file.");
                    tile_names = null;
                    return;
                }
                
                if (tile_names.Count() < NUM_SQUARES)
                {
                    MessageBox.Show(ofd.FileName + " does not contain enough entries to make a bingo card.");
                    tile_names = null;
                }
            } else { MessageBox.Show("No valid file selected."); }
        }
        
        private void GenerateBoard()
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    // Remove random name from list and assign it to button
                    int index = rnd.Next(tile_names.Count());
                    string btn_name = tile_names[index];
                    tile_names.RemoveAt(index);

                    Button btn = new Button
                    {
                        Content = btn_name,
                        Margin = new Thickness(5, 5, 5, 5)
                    };
                    btn.Click += TileButton_Click;
                    Grid.SetColumn(btn, col);
                    Grid.SetRow(btn, row);
                    BoardGrid.Children.Add(btn);
                }
            }
        }

        private bool CheckRows()
        {
            int offset = 1; // first element is the generate grid button. Fix this later, because it's stupid!
            for (int row = 0; row < 5; row++)
            {
                bool bingo = true;
                for (int col = 0; col < 5; col++)
                {
                    bingo &= !((Button)BoardGrid.Children[offset + row + col]).IsEnabled;
                }
                if (bingo) return true;
            }
            return false;
        }

        private bool CheckCols()
        {

            return false;
        }

        private bool CheckDiag()
        {
            return false;
        }
    }
}