using ModelLayer;
using ModelLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLayer
{
    public class BuyerController
    {
        private LocationController lCtr = new LocationController();
        public BuyerController()
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
                buyer = ctx.Buyers.Where(x => x.Phone == phone).Single();
            }
            buyer.Location = lCtr.GetLocation(buyer.ZipCode);
            return buyer;
        }

        public List<Buyer> GetAllBuyers()
        {
            List<Buyer> buyers;
            using (var ctx = new SystemContext())
            {
                buyers = ctx.Buyers.ToList();
            }
            foreach (Buyer buyer in buyers)
            {
                buyer.Location = lCtr.GetLocation(buyer.ZipCode);
            }
            return buyers;
        }

        public void UpdateBuyer(Buyer buyer, List<Property> properties, string name, string address, string zipCode, Location location, string phone, string mobil, string email, string misc, string estateType, double minPrice, double maxPrice,
            double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<Location> desiredLocations, string otherPref, Boolean contactAllowedByBoligOne,
            Boolean contactAllowedByReal, Boolean allowedEmailSpam, Boolean inRKI, Boolean buyerApproved, string bank, Boolean ownesHouse, Boolean livesForRent)
        {
            buyer.Name = name;
            buyer.Properties = properties;
            buyer.Address = address;
            buyer.ZipCode = zipCode;
            buyer.Location = location;
            buyer.Phone = phone;
            buyer.Mobil = mobil;
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
            buyer.DesiredLocations = desiredLocations;
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
    }
}
