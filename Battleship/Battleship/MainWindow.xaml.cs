using System;
using System.Collections.Generic;
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

namespace Battleship
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int BOARD_WIDTH = 10;
        
        private class EnemyButton : Button
        {
            public EnemyButton()
            {
                this.Click += OnClick;
                this.Margin = new Thickness(1, 1, 1, 1);
                this.MinWidth = 40;
                this.MinHeight = 30;
            }
            private void OnClick(object sender, RoutedEventArgs e)
            {
                // Do stuff when clicked here
            }
        }
        private class PlayerButton : Button
        {
            public PlayerButton()
            {
                this.Click += OnClick;
                this.Margin = new Thickness(1, 1, 1, 1);
                this.MinWidth = 40;
                this.MinHeight = 30;
            }

            private void OnClick(object sender, RoutedEventArgs e)
            {
                // Do stuff when clicked here
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            SetUpBoard();
        }

        private void SetUpBoard()
        {
            char row = 'A';
            for (int i = 0; i < BOARD_WIDTH; i++)
            {
                // Set up Enemy Board labels
                Label enemy_row = new Label { Content = row };
                Grid.SetColumn(enemy_row, 0);
                Grid.SetRow(enemy_row, i);

                Label enemy_col = new Label { Content = i + 1, HorizontalAlignment = HorizontalAlignment.Center };
                Grid.SetColumn(enemy_col, i + 1);
                Grid.SetRow(enemy_col, 10);

                EnemyGrid.Children.Add(enemy_row);
                EnemyGrid.Children.Add(enemy_col);

                // Set up Player Board labels
                Label player_row = new Label { Content = row };
                Grid.SetColumn(player_row, 0);
                Grid.SetRow(player_row, i);

                Label player_col = new Label { Content = i + 1, HorizontalAlignment = HorizontalAlignment.Center };
                Grid.SetColumn(player_col, i + 1);
                Grid.SetRow(player_col, 10);

                PlayerGrid.Children.Add(player_row);
                PlayerGrid.Children.Add(player_col);
                row++;

                // Set up grid buttons
                for (int j = 0; j < BOARD_WIDTH; j++)
                {
                    EnemyButton enemy = new EnemyButton();
                    Grid.SetColumn(enemy, i + 1);
                    Grid.SetRow(enemy, j);
                    EnemyGrid.Children.Add(enemy);

                    PlayerButton player = new PlayerButton();
                    Grid.SetColumn(player, i + 1);
                    Grid.SetRow(player, j);
                    PlayerGrid.Children.Add(player);
                }
            }
        }
    }
}
