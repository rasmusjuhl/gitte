using ModelLayer;
using ModelLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace ControlLayer
{
    public class BuyerController
    {
        private LocationController lCtr = new LocationController();
        private DBBuyer dbBuy = new DBBuyer();
        public BuyerController()
        {

        }

        public void InsertBuyer(Buyer buyer)
        {
            dbBuy.InsertBuyer(buyer);
        }
        public Buyer GetBuyerByPhone(string phone)
        {
            return dbBuy.GetBuyerByPhone(phone);
        }

        public List<Buyer> GetAllBuyers()
        {
            return dbBuy.GetAllBuyers();
        }

        public void UpdateBuyer(Buyer buyer, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc, string estateType, double minPrice, double maxPrice,
            double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<Location> desiredLocations, string otherPref, Boolean contactAllowedByBoligOne,
            Boolean contactAllowedByReal, Boolean allowedEmailSpam, Boolean inRKI, Boolean buyerApproved, string bank, Boolean ownesHouse, Boolean livesForRent)
        {
            dbBuy.UpdateBuyer(buyer, properties, name, address, zipCode, phone, mobil, email, misc, estateType, minPrice, maxPrice,
                                lotSizeMin, lotSizeMax, probertySizeMin, probertySizeMax, desiredRoomsMin, desiredRoomsMax, desiredLocations, otherPref, contactAllowedByBoligOne,
                                contactAllowedByReal, allowedEmailSpam, inRKI, buyerApproved, bank, ownesHouse, livesForRent);
        }

        public void DeleteBuyer(Buyer buyer)
        {
            dbBuy.DeleteBuyer(buyer);
        }
    }
}
