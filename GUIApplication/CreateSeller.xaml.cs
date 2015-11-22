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
using GUIApplication.BuyerServiceReference;
using Buyer = GUIApplication.BuyerServiceReference.Buyer;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for CreateSeller.xaml
    /// </summary>
    public partial class CreateSeller : Window
    {
        static ISellerService iSeller = new SellerServiceClient();
        static IBuyerService iBuyer = new BuyerServiceClient();
        static ILocationService iLoc = new LocationServiceClient();
        public CreateSeller()
        {
            InitializeComponent();
        }

        private void BtnCreateCustomer(object sender, RoutedEventArgs e)
        {
            Location loc = iLoc.GetLocation(txtZipCode.Text);
            if(customerType.SelectedIndex == 0)
            {
                Seller seller = new Seller()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Mobil = txtMobil.Text,
                    Email = txtEmail.Text,
                    Misc = txtMisc.Text,
                    //Location = (GUIApplication.SellerServiceReference.Location) loc
                };
                iSeller.InsertSeller(seller);
                this.Close();
            }
            else if(customerType.SelectedIndex == 1)
            {

                Buyer buyer = new Buyer()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Mobil = txtMobil.Text,
                    Email = txtEmail.Text,
                    Misc = txtMisc.Text,
                    //Location = (GUIApplication.SellerServiceReference.Location) loc
                };
                iBuyer.InsertBuyer(buyer);
                this.Close();
            }
            else
            {
                MessageBox.Show("Du skal vælge en kunde type");
            }
        }


        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
        }

        private void txtName_LostFocus(object sender, RoutedEventArgs e)
        {
            txtName.Text = "Navn";
        }
    }
}
