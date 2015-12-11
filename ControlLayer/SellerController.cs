/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * "ControlLayer" er det lag i programmet, som er bindeledet mellem 
 * DatabaseAccessLaget(kommunikation til database) og WCFServiceLaget(kommunikation ud) 
*/
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
        private DBSeller dbSel = new DBSeller();
        public SellerController()
        {

        }

        public void InsertSeller(Seller seller)
        {
            dbSel.InsertSeller(seller);
        }

        public Seller GetSellerById(int id)
        {
            return dbSel.GetSellerById(id);
        }

        public Seller GetSellerByPhone(string phone)
        {
            return dbSel.GetSellerByPhone(phone);
        }

        public Seller GetSellerByMobile(string mobile)
        {
            return dbSel.GetSellerByMobile(mobile);
        }

        public List<Seller> GetAllSellers()
        {
            return dbSel.GetAllSellers();
        }
        public void AddPropertyToSeller(Seller seller, Property property)
        {
            seller.Properties.Add(property);
        }

        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            dbSel.UpdateSeller(seller, properties, name, address, zipCode, phone, mobil, email, misc);
        }

        public void DeleteSeller(Seller seller)
        {
            dbSel.DeleteSeller(seller);
        }
        public List<Property> GetAllProperties(Seller seller)
        {
            return dbSel.GetAllProperties(seller);
        }
    }
}
