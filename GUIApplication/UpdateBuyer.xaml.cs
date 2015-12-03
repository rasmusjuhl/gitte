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
            txtAddress.Text = buyer.Address;
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
