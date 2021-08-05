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
        private Tools m_tools;

        public MainWindow()
        {
            InitializeComponent();

            m_tools = new Tools();

        }

        private void SetPaintModeDeleteFill(object sender, RoutedEventArgs e)
        {
            m_Tools.DrawOnGrid(EditMode.DeleteFill);
        }

        private void SetPaintModeFill(object sender, RoutedEventArgs e)
        {
            m_Tools.DrawOnGrid(EditMode.Fill);
        }

        private void SetPaintModeErase(object sender, RoutedEventArgs e)
        {
            m_Tools.DrawOnGrid(EditMode.Erase);
        }

        private void SetPaintModeDraw(object sender, RoutedEventArgs e)
        {
            m_Tools.DrawOnGrid(EditMode.Draw);
        }

    }
}
