using ControlLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
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

        public List<Seller> GetAllSellers()
        {
            return sCtr.GetAllSellers();
        }

        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, Location location, string phone, string mobil, string email, string misc)
        {
            sCtr.UpdateSeller(seller, properties, name,  address, location, phone, mobil, email, misc);
        }

        public void DeleteSeller(Seller seller)
        {
            sCtr.DeleteSeller(seller);
        }
    }
}
