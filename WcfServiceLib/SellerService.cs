using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;

namespace WcfServiceLib
{
    public class SellerService : ISellerService
    {
        static SellerController sCtr = new SellerController();
        public void InsertSeller(ModelLayer.Seller seller)
        {
            sCtr.InsertSeller(seller);
        }

        public ModelLayer.Seller GetSellerByPhone(string phone)
        {
            return sCtr.GetSellerByPhone(phone);
        }

        public ModelLayer.Seller GetSellerByMobile(string mobile)
        {
            return sCtr.GetSellerByMobile(mobile);
        }

        public List<ModelLayer.Seller> GetAllSellers()
        {
            return sCtr.GetAllSellers();
        }

        public void UpdateSeller(ModelLayer.Seller seller, List<ModelLayer.Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            sCtr.UpdateSeller(seller, properties, name, address, zipCode, phone, mobil, email, misc);
        }

        public void DeleteSeller(ModelLayer.Seller seller)
        {
            sCtr.DeleteSeller(seller);
        }
    }
}
