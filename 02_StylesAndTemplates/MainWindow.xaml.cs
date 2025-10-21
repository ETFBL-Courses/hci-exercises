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

namespace _02_StylesAndTemplates
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

        private void Action1Button_Click(object sender, RoutedEventArgs e)
        {
            new CalendarsWindow().ShowDialog();
        }

        private void Action2Button_Click(object sender, RoutedEventArgs e)
        {
            new UnusualButtonsWindow().ShowDialog();
        }

        private void Action3Button_Click(object sender, RoutedEventArgs e)
        {
            new AnimationWindow().ShowDialog();
        }

        private void Action4Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a message box.", Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
