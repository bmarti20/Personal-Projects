using Microsoft.Win32;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            ReadBingoTitles();
        }

        private void TileButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private bool ReadBingoTitles()
        {
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
                List<string> lines = File.ReadAllLines(ofd.FileName).ToList();
                if (lines.Count() < NUM_SQUARES)
                {
                    MessageBox.Show(ofd.FileName + " does not contain enough entries to make a bingo card.");
                    return false;
                }

                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        // Remove random name from list and assign it to button
                        int index = rnd.Next(lines.Count());
                        string btn_name = lines[index];
                        lines.RemoveAt(index);

                        Button btn = new Button
                        {
                            Content = btn_name, 
                            Margin = new Thickness(5, 5, 5, 5)
                        };
                        btn.Click += TileButton_Click;
                        Grid.SetColumn(btn, col);
                        Grid.SetRow(btn, row);
                        MainGrid.Children.Add(btn);
                    }
                }
            } else
            {
                MessageBox.Show("No valid file selected.");
                return false;
            }
            return true;
        }
    }
}