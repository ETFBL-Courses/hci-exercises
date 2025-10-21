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

namespace _01_Intro
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello, {(string.IsNullOrWhiteSpace(NameTextBox.Text) ? "John Doe" : NameTextBox.Text.Trim())}!");
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("Window_PreviewKeyDown");
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("Grid_PreviewKeyDown");
            // e.Handled = true;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("TextBox_PreviewKeyDown");
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("TextBox_KeyDown");
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("Grid_KeyDown");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("Window_KeyDown");
        }
    }
}