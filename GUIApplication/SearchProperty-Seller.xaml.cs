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

        public SearchProperty_Seller()
        {
            InitializeComponent();
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            Property property;
            Seller seller;
            if (txtPropertyAddress.Text != "")
            {
                property = iProperty.GetProperty(txtPropertyAddress.Text);
                txtZipcode.Text = property.ZipCode;
                txtMtkNr.Text = "Matrikelnummer her";
                txtSellerName.Text = "Get seller name here";
                txtSellerAddress.Text = "Get seller address here";
                txtSellerPhone.Text = "Get seller phone here";
                txtSellerMobile.Text = "Get seller mobile here";
            }
        }
    }
}
