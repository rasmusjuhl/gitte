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
using GUIApplication.BuyerServiceReference;
using Buyer = GUIApplication.BuyerServiceReference.Buyer;
using GUIApplication.LocationServiceReference;
using Location = GUIApplication.LocationServiceReference.Location;
using GUIApplication.PropertyServiceReference;
using Property = GUIApplication.SellerServiceReference.Property;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static IUserService iUser = new UserServiceClient();
        static ISellerService iSeller = new SellerServiceClient();
        static IBuyerService iBuyer = new BuyerServiceClient();
        static ILocationService iLoc = new LocationServiceClient();
        static IPropertyService iProp = new PropertyServiceClient();

        public MainWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            User user = iUser.GetAllUsers().First();
            InitializeComponent();
            txtUser.Text = user.Name + ", " + DateTime.Today.Day + "/" + DateTime.Today.Month + "-" + DateTime.Today.Year;
        }

        private void sellerData_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateSellerDatagrid(sender);
        }

        //Viser info om en kunde, både fra buyer og seller tab
        private void BtnVisInfo(object sender, RoutedEventArgs e)
        {
            if (buyerTab.IsSelected)
            {
                Buyer buyer = (Buyer)buyerData.SelectedItem;
                Location loc = iLoc.GetLocation(buyer.ZipCode);
                MessageBox.Show("KøberID: " + buyer.Id + "\nNavn: " + buyer.Name + "\nAdresse: " + buyer.Address + "\nPostnummer: " + buyer.ZipCode + " By: " + loc.City + "\nTelefon: " + buyer.Phone + "\nMobil: " + buyer.Mobile + "\nEmail: " + buyer.Email + "\nMisc: " + buyer.Misc);
            }
            else
            {
                Seller seller = (Seller)sellerData.SelectedItem;
                Location loc = iLoc.GetLocation(seller.ZipCode);
                MessageBox.Show("SælgerID: " + seller.Id + "\nNavn: " + seller.Name + "\nAdresse: " + seller.Address + "\nPostnummer: " + seller.ZipCode + " By: " + loc.City + "\nTelefon: " + seller.Phone + "\nMobil: " + seller.Mobile + "\nEmail: " + seller.Email + "\nMisc: " + seller.Misc);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Print!");
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Refresh!");
        }

        //Opret kunde; buyer eller seller
        private void BtnCreateCustomer(object sender, RoutedEventArgs e)
        {
            CreateSeller window = new CreateSeller();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Topmost = true;
            window.Show();
        }

        private void buyerData_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateBuyerDatagrid(sender);
        }

        private void BtnUpdateCustomer(object sender, RoutedEventArgs e)
        {
            if (buyerTab.IsSelected)
            {
                Buyer buyer = (Buyer)buyerData.SelectedItem;
                //UpdateCustomer window = new UpdateCustomer(buyer);
                //window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                //window.Topmost = true;
                //window.Show();
            }
            else
            {
                Seller seller = (Seller)sellerData.SelectedItem;
                UpdateSeller window = new UpdateSeller(seller);
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.Topmost = false;
                window.Show();
            }
        }

        private void BtnDeleteCustomer(object sender, RoutedEventArgs e)
        {
            if (buyerTab.IsSelected)
            {
                Buyer buyer = (Buyer)buyerData.SelectedItem;
                iBuyer.DeleteBuyer(buyer);
            }
            else
            {
                Seller seller = (Seller)sellerData.SelectedItem;
                iSeller.DeleteSeller(seller);
            }
        }
        private void UpdateBuyerDatagrid(object sender)
        {
            List<Buyer> buyers = iBuyer.GetAllBuyers().ToList();
            var grid = sender as DataGrid;
            grid.ItemsSource = buyers;
        }
        private void UpdateSellerDatagrid(object sender)
        {
            List<Seller> sellers = iSeller.GetAllSellers();
            var grid = sender as DataGrid;
            grid.ItemsSource = sellers;
        }

    }

}
