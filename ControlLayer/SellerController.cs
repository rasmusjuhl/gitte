using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;

namespace ControlLayer
{
    public class SellerController
    {
        public SellerController()
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
        public Seller GetUser(string phone)
        {
            List<Seller> seller;
            using (var ctx = new SystemContext())
            {
                var res = from x in ctx.Sellers
                          where x.Phone == phone
                          select x;
                seller = res.ToList();
            }
            return seller.First();
        }

        public List<Seller> GetAllSellers()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Sellers.ToList();
            }
        }

        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, Location location, string phone, string mobil, string email, string misc)
        {
            seller.Name = name;
            seller.Properties = properties;
            seller.Address = address;
            seller.Location = location;
            seller.Phone = phone;
            seller.Mobil = mobil;
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
