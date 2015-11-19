using ControlLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    public class BuyerService : IBuyerService
    {
        static BuyerController bCtr = new BuyerController();
        public void InsertBuyer(Buyer buyer)
        {
            bCtr.InsertBuyer(buyer);
        }

        public Buyer GetBuyerByPhone(string phone)
        {
            return bCtr.GetBuyerByPhone(phone);
        }

        public List<Buyer> GetAllBuyers()
        {
            return bCtr.GetAllBuyers();
        }

        public void UpdateBuyer(Buyer buyer, List<Property> properties, string name, string address, Location location, string phone, string mobil, string email, string misc, string estateType, double minPrice, double maxPrice, double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<Location> desiredLocations, string otherPref, bool contactAllowedByBoligOne, bool contactAllowedByReal, bool allowedEmailSpam, bool inRKI, bool buyerApproved, string bank, bool ownesHouse, bool livesForRent)
        {
            bCtr.UpdateBuyer(buyer, properties, name, address, location, phone, mobil, email, misc, estateType, minPrice, maxPrice, lotSizeMin, lotSizeMax, probertySizeMin, probertySizeMax, desiredRoomsMin, desiredRoomsMax, desiredLocations, otherPref, contactAllowedByBoligOne, contactAllowedByReal, allowedEmailSpam, inRKI, buyerApproved, bank, ownesHouse, livesForRent);
        }

        public void DeleteBuyer(Buyer buyer)
        {
            bCtr.DeleteBuyer(buyer);
        }
    }
}
