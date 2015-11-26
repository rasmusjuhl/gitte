using GUIApplication.BuyerServiceReference;
using Buyer = GUIApplication.BuyerServiceReference.Buyer;
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

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for BuyerFinishWindow.xaml
    /// </summary>
    public partial class BuyerFinishWindow : Window
    {
        static IBuyerService iBuyer = new BuyerServiceClient();
        private Buyer buyer;
        public BuyerFinishWindow(Buyer b)
        {
            buyer = b;
            InitializeComponent();
        }

        private void BtnSaveAndClose(object sender, RoutedEventArgs e)
        {
            if (checkInRKI.IsChecked == true)
            {
                buyer.InRKI = true;
            }
            if (checkBuyerApproved.IsChecked == true)
            {
                buyer.BuyerApproved = true;
                buyer.Bank = txtBank.Text;

                // INDSÆT BELØB HER  SKAL OPRETTES I MODELLEN   Convert.ToDouble(txtApprovedAmount.Text);
            }
            if (checkOwner.IsChecked == true)
            {
                buyer.OwnesHouse = true;
            }
            if (checkRents.IsChecked == true)
            {
                buyer.LivesForRent = true;
            }
            iBuyer.InsertBuyer(buyer);
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
