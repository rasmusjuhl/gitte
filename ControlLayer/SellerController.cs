using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;
using DBLayer;

namespace ControlLayer
{
    public class SellerController
    {
        private LocationController lCtr = new LocationController();
        private DBSeller dbSel = new DBSeller();
        public SellerController()
        {

        }

        public void InsertSeller(Seller seller)
        {
            dbSel.InsertSeller(seller);
        }
        public Seller GetSellerByPhone(string phone)
        {
            return dbSel.GetSellerByPhone(phone);
        }

        public List<Seller> GetAllSellers()
        {
            return dbSel.GetAllSellers();
        }

        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            dbSel.UpdateSeller(seller, properties, name, address, zipCode, phone, mobil, email, misc);
        }

        public void DeleteSeller(Seller seller)
        {
            dbSel.DeleteSeller(seller);
        }
    }
}
