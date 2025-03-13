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
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            DrawGraph();
        }

        private void DrawGraph()
        {
            double width = 500;
            double height = 500;
            double scaleX = width / 40;
            double scaleY = height / 40;


            DrawLine(0, height / 2, width, height / 2, Brushes.Black);
            DrawLine(width / 2, 0, width / 2, height, Brushes.Black);


            for (int x = -20; x <= 20; x += 2)
            {
                double screenX = width / 2 + x * scaleX;
                double screenY = height / 2;
                DrawLine(screenX, screenY - 5, screenX, screenY + 5, Brushes.Black);
                DrawText(x.ToString(), screenX - 5, screenY + 10, Brushes.Black);

            }


            for (int y = -20; y <= 20; y += 2)
            {
                double screenX = width / 2;
                double screenY = height / 2 - y * scaleY;
                DrawLine(screenX - 5, screenY, screenX + 5, screenY, Brushes.Black);

                if (y != 0)
                {
                    DrawText(y.ToString(), screenX - 20, screenY - 5, Brushes.Black);
                }
            }


            for (double x = -20; x <= 20; x += 0.01)
            {
                double y = Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 3.5;
                double screenX = width / 2 + x * scaleX;
                double screenY = height / 2 - y * scaleY;
                DrawPoint(screenX, screenY, Brushes.Red);
            }
        }

        private void DrawLine(double x1, double y1, double x2, double y2, Brush brush)
        {
            var line = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = brush,
                StrokeThickness = 1
            };
            myCanvas.Children.Add(line);
        }


        private void DrawPoint(double x, double y, Brush brush)
        {
            var ellipse = new Ellipse
            {
                Width = 3,
                Height = 3,
                Fill = brush
            };
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
            myCanvas.Children.Add(ellipse);
        }


        private void DrawText(string text, double x, double y, Brush brush)
        {
            var textBlock = new TextBlock
            {
                Text = text,
                Foreground = brush,
                FontSize = 10
            };
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
            myCanvas.Children.Add(textBlock);


            TextBlock Formula = new TextBlock
            {
                Text = "Y=X³-3X²+3,5",

            };
            Canvas.SetLeft(Formula, 320);
            Canvas.SetTop(Formula, 0);
            myCanvas.Children.Add(Formula);


        }
    }
}