using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;
using ModelLayer;

namespace WcfServiceLib
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

        public Buyer GetBuyerByMobile(string mobile)
        {
            return bCtr.GetBuyerByMobile(mobile);
        }

        public List<Buyer> GetAllBuyers()
        {
           return bCtr.GetAllBuyers();
        }

        public List<Location> GetAllLocationsByPhone(string phone)
        {
            return bCtr.GetAllLocationsByPhone(phone);
        }

        public List<Location> GetAllLocationsByMobile(string mobile)
        {
            return bCtr.GetAllLocationdByMobile(mobile);
        }

        public List<Property> GetAllPropertiesByPhone(string phone)
        {
            return bCtr.GetAllPropertiesByPhone(phone);
        }

        public List<Property> GetAllPropertiesByMobile(string mobile)
        {
            return bCtr.GetAllPropertiesByMobile(mobile);
        }

        public void UpdateBuyer(Buyer buyer, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc, string estateType, double minPrice, double maxPrice, double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<ModelLayer.Location> desiredLocations, string otherPref, bool contactAllowedByBoligOne, bool contactAllowedByReal, bool allowedEmailSpam, bool inRKI, bool buyerApproved, string bank, bool ownesHouse, bool livesForRent)
        {
            bCtr.UpdateBuyer(buyer, properties, name, address, zipCode, phone, mobil, email, misc, estateType, minPrice, maxPrice, lotSizeMin, lotSizeMax, probertySizeMin, probertySizeMax, desiredRoomsMin, desiredRoomsMax, desiredLocations, otherPref, contactAllowedByBoligOne, contactAllowedByReal, allowedEmailSpam, inRKI, buyerApproved, bank, ownesHouse, livesForRent);
        }

        public void DeleteBuyer(Buyer buyer)
        {
            bCtr.DeleteBuyer(buyer);
        }
    }
}
