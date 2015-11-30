using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;
using ModelLayer;

namespace WcfServiceLib
{
    public class SellerService : ISellerService
    {
        static SellerController sCtr = new SellerController();
        public void InsertSeller(Seller seller)
        {
            sCtr.InsertSeller(seller);
        }

        public Seller GetSellerByPhone(string phone)
        {
            return sCtr.GetSellerByPhone(phone);
        }

        public Seller GetSellerByMobile(string mobile)
        {
            return sCtr.GetSellerByMobile(mobile);
        }

        public List<Seller> GetAllSellers()
        {
            return sCtr.GetAllSellers();
        }

        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            sCtr.UpdateSeller(seller, properties, name, address, zipCode, phone, mobil, email, misc);
        }

        public void DeleteSeller(Seller seller)
        {
            sCtr.DeleteSeller(seller);
        }
    }
}
