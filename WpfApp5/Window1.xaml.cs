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

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DrawBug();

        }

        private void DrawBug()
        {


            Line antennaLeft = new Line
            {
                X1 = 190,
                Y1 = 60,
                X2 = 180,
                Y2 = 40,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(antennaLeft);

            Line antennaRight = new Line
            {
                X1 = 210,
                Y1 = 60,
                X2 = 220,
                Y2 = 40,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(antennaRight);



            Line antenna2Left = new Line
            {
                X1 = 150,
                Y1 = 40,
                X2 = 180,
                Y2 = 40,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(antenna2Left);

            Line antenna2Right = new Line
            {
                X1 = 250,
                Y1 = 40,
                X2 = 220,
                Y2 = 40,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(antenna2Right);


            Ellipse head = new Ellipse
            {
                Width = 80,
                Height = 100,
                Fill = Brushes.Black,
                Stroke = Brushes.Black
            };
            Canvas.SetLeft(head, 160);
            Canvas.SetTop(head, 50);
            myCanvas.Children.Add(head);


            Ellipse body = new Ellipse
            {
                Width = 200,
                Height = 250,
                Fill = Brushes.Red,
                Stroke = Brushes.Black,
                StrokeThickness = 5
            };
            Canvas.SetLeft(body, 100);
            Canvas.SetTop(body, 100);
            myCanvas.Children.Add(body);

            Line centerLine = new Line
            {
                X1 = 200,
                Y1 = 100,
                X2 = 200,
                Y2 = 350,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(centerLine);

            void AddDot(double x, double y)
            {
                Ellipse dot = new Ellipse
                {
                    Width = 30,
                    Height = 30,
                    Fill = Brushes.Black
                };
                Canvas.SetLeft(dot, x);
                Canvas.SetTop(dot, y);
                myCanvas.Children.Add(dot);
            }
            AddDot(160, 130);
            AddDot(140, 170);
            AddDot(120, 210);
            AddDot(140, 250);
            AddDot(160, 290);

            AddDot(210, 130);
            AddDot(230, 170);
            AddDot(250, 210);
            AddDot(230, 250);
            AddDot(210, 290);



        }
    }
}