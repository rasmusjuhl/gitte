using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;
using System.Data.Entity;
using System.Windows;

namespace DBLayer
{
    public class DBBuyer
    {
        public DBBuyer()
        {

        }

        public void InsertBuyer(Buyer buyer)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Buyers.Add(buyer);
                ctx.SaveChanges();
            }
        }

        public Buyer GetBuyerByPhone(string phone)
        {
            Buyer buyer;
            using (var ctx = new SystemContext())
            {
                buyer = ctx.Buyers.Where(x => x.Phone == phone).SingleOrDefault();
            }
            return buyer;
        }

        public Buyer GetBuyerByMobile(string mobile)
        {
            Buyer buyer;
            using (var ctx = new SystemContext())
            {
                buyer = ctx.Buyers.Where(x => x.Mobile == mobile).SingleOrDefault();
            }
            return buyer;
        }

        public List<Buyer> GetAllBuyers()
        {
            List<Buyer> buyers;
            using (var ctx = new SystemContext())
            {
                buyers = ctx.Buyers.ToList();
            }
            return buyers;
        }

        public List<Location> GetAllLocationsByPhone(string phone)
        {
            List<Location> locations;
            using (var ctx = new SystemContext())
            {
                Buyer b = ctx.Buyers.Where(x => x.Phone == phone).SingleOrDefault();
                locations = b.Locations.ToList();
            }
            return locations;
        }

        public List<Location> GetAllLocationsByMobile(string mobile)
        {
            List<Location> locations;
            using (var ctx = new SystemContext())
            {
                Buyer b = ctx.Buyers.Where(x => x.Mobile == mobile).SingleOrDefault();
                locations = b.Locations.ToList();
            }
            return locations;
        }

        public List<Property> GetAllPropertiesByPhone(string phone)
        {
            List<Property> properties;
            using (var ctx = new SystemContext())
            {
                Buyer b = ctx.Buyers.Where(x => x.Phone == phone).SingleOrDefault();
                properties = b.Properties.ToList();
            }
            return properties;
        }

        public List<Property> GetAllPropertiesByMobile(string mobile)
        {
            List<Property> properties;
            using (var ctx = new SystemContext())
            {
                Buyer b = ctx.Buyers.Where(x => x.Mobile == mobile).SingleOrDefault();
                properties = b.Properties.ToList();
            }
            return properties;
        }

        public void UpdateBuyer(Buyer buyer, List<Property> properties, string name, string address, string zipCode, string phone, string mobile, string email, string misc, string estateType, double minPrice, double maxPrice,
            double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<Location> locations, string otherPref, Boolean contactAllowedByBoligOne,
            Boolean contactAllowedByReal, Boolean allowedEmailSpam, Boolean inRKI, Boolean buyerApproved, string bank, Boolean ownesHouse, Boolean livesForRent)
        {
            buyer.Name = name;
            buyer.Properties = properties;
            buyer.Address = address;
            buyer.ZipCode = zipCode;
            buyer.Phone = phone;
            buyer.Mobile = mobile;
            buyer.Email = email;
            buyer.Misc = misc;
            buyer.EstateType = estateType;
            buyer.MinPrice = minPrice;
            buyer.MaxPrice = maxPrice;
            buyer.LotSizeMin = lotSizeMin;
            buyer.LotSizeMax = lotSizeMax;
            buyer.ProbertySizeMin = probertySizeMin;
            buyer.ProbertySizeMax = probertySizeMax;
            buyer.DesiredRoomsMin = desiredRoomsMin;
            buyer.DesiredRoomsMax = desiredRoomsMax;
            buyer.Locations = locations;
            buyer.OtherPref = otherPref;
            buyer.ContactAllowedByBoligOne = contactAllowedByBoligOne;
            buyer.ContactAllowedByReal = contactAllowedByReal;
            buyer.AllowedEmailSpam = allowedEmailSpam;
            buyer.InRKI = inRKI;
            buyer.BuyerApproved = buyerApproved;
            buyer.Bank = bank;
            buyer.OwnesHouse = ownesHouse;
            buyer.LivesForRent = livesForRent;
            using (var ctx = new SystemContext())
            {
                ctx.Entry(buyer).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void DeleteBuyer(Buyer buyer)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Buyers.Attach(buyer);
                ctx.Buyers.Remove(buyer);
                ctx.SaveChanges();
            }
        }

        public Buyer GetBuyerById(int id)
        {
            Buyer buyer;
            using (var ctx = new SystemContext())
            {
                buyer = ctx.Buyers.Find(id);
            }
            return buyer;
        }
    }
}
