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
            if (customerType.SelectedIndex == 0)
            {
                Seller seller = new Seller()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    ZipCode = txtZipCode.Text,
                    Phone = txtPhone.Text,
                    Mobil = txtMobil.Text,
                    Email = txtEmail.Text,
                    Misc = txtMisc.Text,
                };
                iSeller.InsertSeller(seller);
                this.Close();
            }
            else if (customerType.SelectedIndex == 1)
            {

                Buyer buyer = new Buyer()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    ZipCode = txtZipCode.Text,
                    Phone = txtPhone.Text,
                    Mobil = txtMobil.Text,
                    Email = txtEmail.Text,
                    Misc = txtMisc.Text,
                };
                iBuyer.InsertBuyer(buyer);
                this.Close();
            }
            else
            {
                MessageBox.Show("Du skal vælge en kunde type");
            }
        }
        private void BtnAnnuller(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCreateNext(object sender, RoutedEventArgs e)
        {
            if(customerType.SelectedIndex == 0)
            {
                //Window skal laves

                //SellerDetailsWindow window = new SellerDetailsWindow();
                //window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                //window.Topmost = true;
                //window.Show();
            }
            else if(customerType.SelectedIndex == 1)
            {
                BuyerPrefsWindow window = new BuyerPrefsWindow();
                this.Topmost = false;
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.Topmost = true;
                window.Show();
            }
        }


        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "Navn")
            {
                txtName.Text = "";
            }
        }

        private void txtName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "")
                txtName.Text = "Navn";
        }

        private void txtAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtAddress.Text == "Adresse")
                txtAddress.Text = "";
        }

        private void txtAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtAddress.Text == "")
                txtAddress.Text = "Adresse";
        }

        private void txtZipCode_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtZipCode.Text == "Postnummer")
                txtZipCode.Text = "";
        }

        private void txtZipCode_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtZipCode.Text == "")
            {
                txtZipCode.Text = "Postnummer";
            }
            else
            {
                try
                {
                    lblCity.Content = iLoc.GetLocation(txtZipCode.Text).City;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ugyldigt postnummer!");
                }                
            }
        }

        private void txtPhone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPhone.Text == "Telefon")
                txtPhone.Text = "";
        }

        private void txtPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPhone.Text == "")
                txtPhone.Text = "Telefon";
        }

        private void txtMobil_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtMobil.Text == "Mobil")
                txtMobil.Text = "";
        }

        private void txtMobil_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtMobil.Text == "")
                txtMobil.Text = "Mobil";
        }

        private void txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text == "Email")
                txtEmail.Text = "";
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Email";
        }

        private void txtMisc_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtMisc.Text == "Diverse")
                txtMisc.Text = "";
        }

        private void txtMisc_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtMisc.Text == "")
                txtMisc.Text = "Diverse";
        }

        
    }
}
