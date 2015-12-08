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
using GUIApplication.PropertyServiceReference;
using Property = GUIApplication.PropertyServiceReference.Property;
using GUIApplication.SellerServiceReference;
using Seller = GUIApplication.SellerServiceReference.Seller;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for SearchProperty_Seller.xaml
    /// </summary>
    public partial class SearchProperty_Seller : Window
    {
        static IPropertyService iProperty = new PropertyServiceClient();
        static ISellerService iSeller = new SellerServiceClient();

        private CreateAppointment sourceWin;

        public SearchProperty_Seller(CreateAppointment source)
        {
            InitializeComponent();
            this.sourceWin = source;
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            Property property;
            Seller seller;
            if (txtPropertyAddress.Text != "")
            {
                property = iProperty.GetProperty(txtPropertyAddress.Text);
                seller = iSeller.GetSellerById(property.SellerID);
                txtZipcode.Text = property.ZipCode;
                txtMtkNr.Text = "Matrikelnummer her";
                txtSellerName.Text = seller.Name;
                txtSellerAddress.Text = seller.Address;
                txtSellerPhone.Text = seller.Phone;
                txtSellerMobile.Text = seller.Mobile;
            }

            else if (txtSellerPhone.Text != "")
            {
                seller = iSeller.GetSellerByPhone(txtSellerPhone.Text);
                property = iProperty.GetPropertyBySellerID(seller.Id);
                txtPropertyAddress.Text = property.Address;
                txtZipcode.Text = property.ZipCode;
                txtMtkNr.Text = "Matrikelnummer her";
                txtSellerName.Text = seller.Name;
                txtSellerAddress.Text = seller.Address;
                txtSellerMobile.Text = seller.Mobile;
            }

            else if (txtSellerMobile.Text != "")
            {
                seller = iSeller.GetSellerByMobile(txtSellerMobile.Text);
                property = iProperty.GetPropertyBySellerID(seller.Id);
                txtPropertyAddress.Text = property.Address;
                txtZipcode.Text = property.ZipCode;
                txtMtkNr.Text = "Matrikelnummer her";
                txtSellerName.Text = seller.Name;
                txtSellerAddress.Text = seller.Address;
                txtSellerPhone.Text = seller.Phone;
            }

            else
            {
                MessageBox.Show("Indtast beliggenhed eller sælgernummer");
            }
        }

        private void Button_Annuller(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Choose(object sender, RoutedEventArgs e)
        {
            sourceWin.txtBuyerSubject.Text = txtSellerPhone.Text;
            this.Close();
        }
    }
}
