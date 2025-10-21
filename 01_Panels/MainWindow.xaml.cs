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

namespace _01_Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanvasButton_Click(object sender, RoutedEventArgs e)
        {
            new CanvasWindow().ShowDialog();
        }

        private void DockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            new DockPanelWindow().ShowDialog();
        }

        private void GridButton_Click(object sender, RoutedEventArgs e)
        {
            new GridWindow().ShowDialog();
        }

        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            new StackPanelWindow().ShowDialog();
        }

        private void WrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            new WrapPanelWindow().ShowDialog();
        }
    }
}
