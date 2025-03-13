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

    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Pyramid();

        }

        private void Pyramid()
        {

            Line Line1 = new Line
            {
                X1 = 200,
                Y1 = 50,
                X2 = 100,
                Y2 = 300,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(Line1);

            Line Line2 = new Line
            {
                X1 = 200,
                Y1 = 50,
                X2 = 300,
                Y2 = 300,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(Line2);

            Line Line3 = new Line
            {
                X1 = 100,
                Y1 = 300,
                X2 = 300,
                Y2 = 300,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            myCanvas.Children.Add(Line3);

            Line Line4 = new Line
            {
                X1 = 100,
                Y1 = 300,
                X2 = 250,
                Y2 = 285,
                Stroke = Brushes.Black,
                StrokeThickness = 1.25,
                StrokeDashArray = new
                DoubleCollection { 4, 2 }
            };
            myCanvas.Children.Add(Line4);

            Line Line5 = new Line
            {
                X1 = 200,
                Y1 = 50,
                X2 = 250,
                Y2 = 285,
                Stroke = Brushes.Black,
                StrokeThickness = 1.25,
                StrokeDashArray = new
                DoubleCollection { 4, 2 }
            };
            myCanvas.Children.Add(Line5);

            Line Line6 = new Line
            {
                X1 = 200,
                Y1 = 50,
                X2 = 200,
                Y2 = 270,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                StrokeDashArray = new
                DoubleCollection { 4, 2 }
            };
            myCanvas.Children.Add(Line6);

            Line Line7 = new Line
            {
                X1 = 100,
                Y1 = 300,
                X2 = 200,
                Y2 = 270,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                StrokeDashArray = new
                DoubleCollection { 4, 2 }
            };
            myCanvas.Children.Add(Line7);

            Line Line8 = new Line
            {
                X1 = 300,
                Y1 = 300,
                X2 = 200,
                Y2 = 270,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                StrokeDashArray = new
                DoubleCollection { 4, 2 }
            };
            myCanvas.Children.Add(Line8);


            Polygon Triangle = new Polygon
            {
                Points = new PointCollection {new Point(200,50), new Point(100, 300), new Point(250, 285)},
                Fill = new SolidColorBrush(Color.FromArgb(128,0,0,255))
            };
            myCanvas.Children.Add(Triangle);


            TextBlock A = new TextBlock
            {
                Text = "A",

            };
            Canvas.SetLeft(A, 85);
            Canvas.SetTop(A, 285);
            myCanvas.Children.Add(A);

            TextBlock B = new TextBlock
            {
                Text = "B",

            };
            Canvas.SetLeft(B, 210);
            Canvas.SetTop(B, 45);
            myCanvas.Children.Add(B);

            TextBlock C = new TextBlock
            {
                Text = "C",

            };
            Canvas.SetLeft(C, 305);
            Canvas.SetTop(C, 285);
            myCanvas.Children.Add(C);

            TextBlock D = new TextBlock
            {
                Text = "D",

            };
            Canvas.SetLeft(D, 205);
            Canvas.SetTop(D, 250);
            myCanvas.Children.Add(D);

            TextBlock K = new TextBlock
            {
                Text = "K",

            };
            Canvas.SetLeft(K, 253);
            Canvas.SetTop(K, 267);
            myCanvas.Children.Add(K);

            TextBlock V = new TextBlock
            {
                Text = "Вариант 2. В треугольной пирамиде построить сечение, проходящее через боковое ребро и медиану основания.",
                Width = 400,
                TextWrapping = TextWrapping.Wrap
            };
            myCanvas.Children.Add(V);




        }
    }
}
