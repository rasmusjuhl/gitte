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
using GUIApplication.LocationServiceReference;
using Location = GUIApplication.LocationServiceReference.Location;
using GUIApplication.BuyerServiceReference;
using Buyer = GUIApplication.BuyerServiceReference.Buyer;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for UpdateCustomer.xaml
    /// </summary>
    public partial class UpdateBuyer : Window
    {
        static ILocationService iLoc = new LocationServiceClient();
        private Buyer buyer;
        public UpdateBuyer(Buyer buyer)
        {
            this.buyer = buyer;
            InitializeComponent();
            AddText();
        }

        private void AddText()
        {
            txtName.Text = buyer.Name;
            txtAddress.Text = buyer.Address;
            txtZipCode.Text = buyer.ZipCode;
            txtPhone.Text = buyer.Phone;
            txtMobile.Text = buyer.Mobile;
            txtEmail.Text = buyer.Email;
            txtMisc.Text = buyer.Misc;

            txtPriceMin.Text = Convert.ToString(buyer.MinPrice);
            txtPriceMax.Text = Convert.ToString(buyer.MaxPrice);
            txtPropertyMin.Text = Convert.ToString(buyer.LotSizeMin);
            txtPropertyMax.Text = Convert.ToString(buyer.LotSizeMax);
            txtRoomsMin.Text =  Convert.ToString(buyer.DesiredRoomsMin);
            txtRoomsMax.Text = Convert.ToString(buyer.DesiredRoomsMax);
            txtLotMin.Text =  Convert.ToString(buyer.LotSizeMin);
            txtLotMax.Text =  Convert.ToString(buyer.LotSizeMax);
            txtMisc.Text = buyer.Misc;
            if(buyer.InRKI == true)
            {
                checkInRKI.IsChecked = true;
            }
            if(buyer.BuyerApproved == true)
            {
                checkBuyerApproved.IsChecked = true;
                txtBank.Text = buyer.Bank;
                //INDSÆT BELØB
            }
            if(buyer.OwnesHouse == true)
            {
                checkOwner.IsChecked = true;
            }
            if(buyer.LivesForRent == true)
            {
                checkRents.IsChecked = true;
            }
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

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate(object sender, RoutedEventArgs e)
        {

        }
        private void txtPriceMin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPriceMin.Text == "Pris fra")
            {
                txtPriceMin.Text = "";
            }
        }

        private void txtPriceMax_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPriceMax.Text == "Pris til")
            {
                txtPriceMax.Text = "";
            }
        }

        private void txtPropertyMin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPropertyMin.Text == "Boligareal fra")
            {
                txtPropertyMin.Text = "";
            }
        }

        private void txtRoomsMin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtRoomsMin.Text == "Værelser fra")
            {
                txtRoomsMin.Text = "";
            }
        }

        private void txtLotMin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtLotMin.Text == "Grundareal fra")
            {
                txtLotMin.Text = "";
            }
        }

        private void txtPropertyMax_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPropertyMax.Text == "Boligareal til")
            {
                txtPropertyMax.Text = "";
            }
        }

        private void txtRoomsMax_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtRoomsMax.Text == "Værelser til")
            {
                txtRoomsMax.Text = "";
            }
        }

        private void txtLotMax_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtLotMax.Text == "Grundareal til")
            {
                txtLotMax.Text = "";
            }
        }
    }
}
