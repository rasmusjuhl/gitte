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
using GUIApplication.SellerServiceReference;
using Seller = GUIApplication.SellerServiceReference.Seller;
using GUIApplication.PropertyServiceReference;
using Property = GUIApplication.PropertyServiceReference.Property;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for AddPropertyToSellerWindow.xaml
    /// </summary>
    public partial class AddPropertyToSellerWindow : Window
    {
        private Seller seller;
        private CreateSeller createSeller;
        static IPropertyService iProp = new PropertyServiceClient();
        static ISellerService iSeller = new SellerServiceClient();
        public AddPropertyToSellerWindow(Seller s, CreateSeller cs)
        {
            createSeller = cs;
            seller = s;
            InitializeComponent();
        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            createSeller.Close();
            this.Close();
        }

        private void BtnAddProperty(object sender, RoutedEventArgs e)
        {

            Property property = new Property()
            {
                Address = txtAddress.Text,
                ZipCode = txtZipCode.Text,
                Type = txtType.Text,
                Rooms = Convert.ToInt32(txtRooms.Text),
                Floors = Convert.ToInt32(txtFloors.Text),
                Price = Convert.ToDouble(txtPrice.Text),
                PropertySize = Convert.ToDouble(txtLotSize.Text),
                HouseSize = Convert.ToDouble(txtHouseSize.Text),
                ConstructionYear = Convert.ToInt32(txtConstructionYear.Text)
            };
            iSeller.InsertSeller(seller);
            Seller newSeller = iSeller.GetSellerByPhone(seller.Phone);
            property.SellerID = newSeller.Id;
            try
            {
                iProp.InsertProperty(property);
            }
            catch(Exception ex)
            {
                MessageBox.Show("FUCK" + ex);
            }

            this.Close();

        }

        private void BtnSearchAddress(object sender, RoutedEventArgs e)
        {
            Property property = iProp.GetPropertiesByAddress(txtSearchProperty.Text).Single();
            txtAddress.Text = property.Address;
            txtZipCode.Text = property.ZipCode;
            txtRooms.Text = property.Rooms.ToString();
            txtFloors.Text = property.Floors.ToString();
            txtHouseSize.Text = property.HouseSize.ToString();
            txtLotSize.Text = property.PropertySize.ToString();
            txtPrice.Text = property.Price.ToString();
            txtType.Text = property.Type.ToString();
            txtConstructionYear.Text = property.ConstructionYear.ToString();
        }
    }
}
