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

namespace WpfApp1
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

        private void Login_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
            textBox.Foreground = new SolidColorBrush(Color.FromScRgb(100, 0, 0, 0));
            textBox.GotFocus -= Login_GotFocus;
        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            AdminPage page = new AdminPage();
            this.Content = page;
        }
    }
}