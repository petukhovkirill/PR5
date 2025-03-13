using System;
using System.Numerics;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {


        private void ShowBug_Click(object sender, RoutedEventArgs e)
        {
            Window1 BugWindow = new Window1();
            BugWindow.Show();
        }

        private void Pyramid_Click(object sender, RoutedEventArgs e)
        {
            Window2 PyramidWindow = new Window2();
            PyramidWindow.Show();
        }
        private void Graph_Click(object sender, RoutedEventArgs e)
        {
            Window3 GraphWindow = new Window3();
            GraphWindow.Show();
        }

        private void Miner_Click(object sender, RoutedEventArgs e)
        {
            Window4 MinerWindow = new Window4();
            MinerWindow.Show();
        }
    }
}