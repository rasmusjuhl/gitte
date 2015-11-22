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
using User = GUIApplication.UserServiceReference.User;
using GUIApplication.SellerServiceReference;
using Seller = GUIApplication.SellerServiceReference.Seller;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static IUserService iUser = new UserServiceClient();
        static ISellerService iSeller = new SellerServiceClient();
        public MainWindow()
        {
            User user = iUser.GetAllUsers().First();
            InitializeComponent();
            txtUser.Text = user.Name + ", " + DateTime.Today.Day + "/" + DateTime.Today.Month + "-" + DateTime.Today.Year;
        }

        private void sellerData_Loaded(object sender, RoutedEventArgs e)
        {
            List<Seller> sellers = iSeller.GetAllSellers();                      
            var grid = sender as DataGrid;
            grid.ItemsSource = sellers;
        }

        private void BtnVisInfo(object sender, RoutedEventArgs e)
        {
            Seller seller = (Seller) sellerData.SelectedItem;
            MessageBox.Show("SælgerID: " + seller.Id + "\nNavn: " + seller.Name + "\nAddresse: " + seller.Address + "\nTelefon: " + seller.Phone
                + "\nMobil: " + seller.Mobil + "\nEmail: " + seller.Email + "\nMisc: " + seller.Misc);
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Print!");
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Refresh!");
        }

        private void BtnCreateSeller(object sender, RoutedEventArgs e)
        {
            
            
        }

       
    }

}
