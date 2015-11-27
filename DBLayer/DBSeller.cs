using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;

namespace DBLayer
{
    public class DBSeller
    {
        private DBLocation dbLoc = new DBLocation();
        public DBSeller()
        {

        }

        public void InsertSeller(Seller seller)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Sellers.Add(seller);
                ctx.SaveChanges();
            }
        }

        public Seller GetSellerByPhone(string phone)
        {
            Seller seller;
            using (var ctx = new SystemContext())
            {
                seller = ctx.Sellers.Where(x => x.Phone == phone).Single();
            }
            return seller;
        }

        public Seller GetSellerByMobile(string mobile)
        {
            Seller seller;
            using (var ctx = new SystemContext())
            {
                seller = ctx.Sellers.Where(x => x.Mobile == mobile).Single();
            }
            return seller;
        }

        public List<Seller> GetAllSellers()
        {
            List<Seller> sellers;
            using (var ctx = new SystemContext())
            {
                sellers = ctx.Sellers.ToList();
            }
            return sellers;
        }
        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            seller.Name = name;
            seller.Properties = properties;
            seller.Address = address;
            seller.ZipCode = zipCode;
            seller.Phone = phone;
            seller.Mobile = mobil;
            seller.Email = email;
            seller.Misc = misc;
            using (var ctx = new SystemContext())
            {
                ctx.Entry(seller).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void DeleteSeller(Seller seller)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Sellers.Attach(seller);
                ctx.Sellers.Remove(seller);
                ctx.SaveChanges();
            }
        }

    }
}
