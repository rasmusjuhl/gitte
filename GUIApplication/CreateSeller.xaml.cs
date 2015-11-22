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
using GUIApplication.SellerServiceReference;
using Seller = GUIApplication.SellerServiceReference.Seller;
using GUIApplication.LocationServiceReference;
using Location = GUIApplication.LocationServiceReference.Location;


namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for CreateSeller.xaml
    /// </summary>
    public partial class CreateSeller : Window
    {
        static ILocationService iLoc = new LocationServiceClient();
        public CreateSeller()
        {
            InitializeComponent();
        }

        private void BtnCreateCustomer(object sender, RoutedEventArgs e)
        {
            Location loc = iLoc.GetLocation(txtZipCode.Text);
            if(customerType.SelectedIndex == 1)
            {
                Seller seller = new Seller()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Mobil = txtMobil.Text,
                    Email = txtEmail.Text,
                    Misc = txtMisc.Text,
                    Location = (GUIApplication.SellerServiceReference.Location) loc
                };
            }
            
        }
    }
}
