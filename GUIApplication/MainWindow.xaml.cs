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
using GUIApplication.UserServiceReference;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static IUserService iUser = new UserServiceClient();
        public MainWindow()
        {
            User user = iUser.GetAllUsers().First();
            InitializeComponent();
            txtUser.Text = user.Name+ ",        " + DateTime.Today.Day + "/"  + DateTime.Today.Month + "-" + DateTime.Today.Year;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
