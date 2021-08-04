using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MapEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Tools tools;
        private TilesetElements tilesetElements;

        public MainWindow()
        {
            InitializeComponent();

            tools = new Tools();
            tilesetElements = new TilesetElements();


        }

        private void SetPaintModeDeleteFill(object sender, RoutedEventArgs e)
        {

        }

        private void SetPaintModeFill(object sender, RoutedEventArgs e)
        {

        }

        private void SetPaintModeErase(object sender, RoutedEventArgs e)
        {

        }

        private void SetPaintModePaint(object sender, RoutedEventArgs e)
        {

        }

        private class TilesetElements
        {
        }
        private class Tools
        {
        }
    }
}
