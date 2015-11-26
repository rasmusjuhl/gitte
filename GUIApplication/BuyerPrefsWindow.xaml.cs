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

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for BuyerPrefsWindow.xaml
    /// </summary>
    public partial class BuyerPrefsWindow : Window
    {
        public BuyerPrefsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuyerFinishWindow window = new BuyerFinishWindow();
            this.Topmost = false;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Topmost = true;
            window.Show();
        }
    }
}
