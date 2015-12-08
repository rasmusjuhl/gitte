﻿using System;
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
using GUIApplication.BuyerServiceReference;
using Buyer = GUIApplication.BuyerServiceReference.Buyer;
using GUIApplication.LocationServiceReference;
using Location = GUIApplication.LocationServiceReference.Location;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for SearchBuyerWindow.xaml
    /// </summary>
    public partial class SearchBuyerWindow : Window
    {
        static IBuyerService iBuyer = new BuyerServiceClient();
        static ILocationService iLocation = new LocationServiceClient();

        private CreateAppointment sourceWin;
        private Buyer buyer;
        private Location location;

        public SearchBuyerWindow(CreateAppointment source)
        {
            InitializeComponent();
            this.sourceWin = source;
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            if (txtPhone.Text != "")
            {
                buyer = iBuyer.GetBuyerByPhone(txtPhone.Text);
                location = iLocation.GetLocation(buyer.ZipCode);
                txtName.Text = buyer.Name;
                txtAddress.Text = buyer.Address;
                txtZipCode.Text = buyer.ZipCode;
                txtCity.Text = location.City;
                txtMobile.Text = buyer.Mobile;
                txtEmail.Text = buyer.Email;
            }
            else if (txtMobile.Text != "")
            {
                buyer = iBuyer.GetBuyerByMobile(txtMobile.Text);
                location = iLocation.GetLocation(buyer.ZipCode);
                txtName.Text = buyer.Name;
                txtAddress.Text = buyer.Address;
                txtZipCode.Text = buyer.ZipCode;
                txtCity.Text = location.City;
                txtPhone.Text = buyer.Phone;
                txtEmail.Text = buyer.Email;
            }
            else 
            {
                MessageBox.Show("Indtast telefon- eller mobilnummer på kunden");
            }
        }

        private void Button_Annuller(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Choose(object sender, RoutedEventArgs e)
        {
            sourceWin.txtBuyer.Text = txtPhone.Text;
            this.Close();
        }
    }
}
