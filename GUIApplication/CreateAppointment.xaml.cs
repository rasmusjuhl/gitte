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
using GUIApplication.UserServiceReference;
using User = GUIApplication.UserServiceReference.User;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for CreateAppointment.xaml
    /// </summary>
    public partial class CreateAppointment : Window
    {
        static IUserService iUser = new UserServiceClient();
        public CreateAppointment()
        {
            InitializeComponent();
        }

        private void Button_CreateAppointment(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_User(object sender, SelectionChangedEventArgs e)
        {
            cbUser = sender as ComboBox;
        }

        private void cbUser_Loaded(object sender, RoutedEventArgs e)
        {
            List<User> users = iUser.GetAllUsers().ToList();

            cbUser = sender as ComboBox;

            cbUser.ItemsSource = users;
        }
    }
}
