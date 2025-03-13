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
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class Window4 : Window
    {
        private int[,] mineField = new int[3, 3];
        private bool[,] revealed = new bool[3, 3];
        private int mineCount = 2;
        private bool gameOver = false;
        private Random random = new Random();

        public Window4()
        {
            InitializeComponent();
            Initialize2Mine();
        }

        private void Initialize2Mine()
        {
            for (int i = 0; i < mineCount; i++)
            {
                int row = random.Next(0, 3);
                int col = random.Next(0, 3);
                if (mineField[row, col] != -1)
                {
                    mineField[row, col] = -1;
                }
                else
                {
                    i--;
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mineField[i, j] != -1)
                    {
                        mineField[i, j] = CountKolvoMines(i, j);
                    }
                }
            }
        }

        private int CountKolvoMines(int row, int col)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < 3 && j >= 0 && j < 3 && mineField[i, j] == -1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver) return;

            Button button = (Button)sender;
            int row = Grid.GetRow(button);
            int col = Grid.GetColumn(button);
            ChangeBackgroundColor();

            if (mineField[row, col] == -1)
            {
                button.Content = "Мина!";
                Background = Brushes.Red;
                gameOver = true;
                DisableAllButtons();
            }
            else
            {
                button.Content = mineField[row, col].ToString();
            }

            revealed[row, col] = true;
            button.IsEnabled = false;
        }

        private void DisableAllButtons()
        {
            Button00.IsEnabled = false;
            Button01.IsEnabled = false;
            Button02.IsEnabled = false;
            Button10.IsEnabled = false;
            Button11.IsEnabled = false;
            Button12.IsEnabled = false;
            Button20.IsEnabled = false;
            Button21.IsEnabled = false;
            Button22.IsEnabled = false;
        }

        private void ChangeBackgroundColor()
        {
            byte r = (byte)random.Next(256);
            byte g = (byte)random.Next(256);
            byte b = (byte)random.Next(256);
            Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}
