/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * "DBLayer" har ansvaret for at tilgå databasen med de informationer, som brugeren af systemet ønsker at sende med. DBLaget har ansvaret
 * for, igennem systemcontext at oprette en forbindelse til databasen i forbindelse med Entity Framework og foretage de ønskede ændringer.
 * Selve databasen bliver oprettet af Entity Framework i samarbejde med de modelklasser vi har i "ModelLayer".
*/
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

        public Seller GetSellerById(int id)
        {
            Seller seller;
            using (var ctx = new SystemContext())
            {
                seller = ctx.Sellers.Where(x => x.Id == id).SingleOrDefault();
            }
            return seller;
        }

        public Seller GetSellerByPhone(string phone)
        {
            Seller seller;
            using (var ctx = new SystemContext())
            {
                seller = ctx.Sellers.Where(x => x.Phone == phone).SingleOrDefault();
            }
            return seller;
        }

        public Seller GetSellerByMobile(string mobile)
        {
            Seller seller;
            using (var ctx = new SystemContext())
            {
                seller = ctx.Sellers.Where(x => x.Mobile == mobile).SingleOrDefault();
            }
            return seller;
        }

        public List<Seller> GetAllSellers()
        {
            List<Seller> sellers;
            using (var ctx = new SystemContext())
            {
                sellers = ctx.Sellers.Include("Properties").ToList();
            }
            return sellers;
        }
        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            using (var ctx = new SystemContext())
            {
                Seller s = ctx.Sellers.Where(x => x.Id == seller.Id).SingleOrDefault();
                s.Name = name;
                s.Properties = properties;
                s.Address = address;
                s.ZipCode = zipCode;
                s.Phone = phone;
                s.Mobile = mobil;
                s.Email = email;
                s.Misc = misc;

                ctx.Entry(s).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void UpdateSeller(Seller seller)
        {
            using (var ctx = new SystemContext())
            {
                Seller dbSeller = ctx.Sellers.Find(seller.Id);
                ctx.Entry(dbSeller).CurrentValues.SetValues(seller);
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
        public List<Property> GetAllProperties(Seller seller)
        {
            List<Property> properties;
            using (var ctx = new SystemContext())
            {
                properties = ctx.Properties.Where(x => x.SellerID == seller.Id).ToList();
            }
            return properties;
        }

    }
}
