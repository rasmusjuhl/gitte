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
    /// Interaction logic for BuyerPrefsWindow.xaml
    /// </summary>
    public partial class BuyerPrefsWindow : Window
    {
        private Buyer buyer;
        public BuyerPrefsWindow(Buyer b)
        {
            buyer = b;
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buyer.MinPrice = Convert.ToDouble(txtPriceMin.Text);
            buyer.MaxPrice = Convert.ToDouble(txtPriceMax.Text);
            buyer.ProbertySizeMin = Convert.ToDouble(txtPropertyMin.Text);
            buyer.ProbertySizeMax = Convert.ToDouble(txtPropertyMax.Text);
            buyer.DesiredRoomsMin = Convert.ToDouble(txtRoomsMin.Text);
            buyer.DesiredRoomsMax = Convert.ToDouble(txtRoomsMax.Text);
            buyer.LotSizeMin = Convert.ToDouble(txtLotMin.Text);
            buyer.LotSizeMax = Convert.ToDouble(txtLotMax.Text);
            buyer.Misc = txtMisc.Text;
            BuyerFinishWindow window = new BuyerFinishWindow(buyer);
            this.Topmost = false;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Topmost = true;
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
