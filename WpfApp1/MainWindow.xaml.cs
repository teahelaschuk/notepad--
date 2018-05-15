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

// downloading images?? https://msdn.microsoft.com/en-us/library/ez801hhe(v=vs.110).aspx
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random r;
        
        public MainWindow()
        {
            r = new Random();
            InitializeComponent();
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            MenuItemColour_Click(sender, e);
        }

        private void MenuItemColour_Click(object sender, RoutedEventArgs e)
        {
            tbox.Foreground = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
