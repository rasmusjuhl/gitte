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
//using GUIApplication.PropertyServiceReference;
using Property = GUIApplication.SellerServiceReference.Property;


namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for UpdateSeller.xaml
    /// </summary>
    public partial class UpdateSeller : Window
    {
        static ISellerService iSeller = new SellerServiceClient();
        static ILocationService iLoc = new LocationServiceClient();
        //static IPropertyService iProp = new PropertyServiceClient();
        private Seller seller;
        private Property property;
        private List<Property> properties;
        public UpdateSeller(Seller s)
        {
            InitializeComponent();

            property = new Property();
            seller = s;
            properties = seller.Properties;
            AddText();
        }

        private void AddText()
        {
            txtName.Text = seller.Name;
            txtAddress.Text = seller.Address;
            txtZipCode.Text = seller.ZipCode;
            lblCity.Content = iLoc.GetLocation(seller.ZipCode).City;
            txtPhone.Text = seller.Phone;
            txtMobile.Text = seller.Mobile;
            txtEmail.Text = seller.Email;
            txtMisc.Text = seller.Misc;


        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string zipCode = txtZipCode.Text;
            string phone = txtPhone.Text;
            string mobile = txtMobile.Text;
            string email = txtEmail.Text;
            string misc = txtMisc.Text;
            properties.Clear();
            properties.Add(property);
            try
            {
                iSeller.UpdateSeller(seller, properties, name, address, zipCode, phone, mobile, email, misc);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fejl" + ex);
            }
            this.Close();
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


    }
}
