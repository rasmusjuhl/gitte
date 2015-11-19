using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IBuyerService
    {
        [OperationContract]
        void InsertBuyer(Buyer buyer);
        [OperationContract]
        Buyer GetBuyerByPhone(string phone);
        [OperationContract]
        List<Buyer> GetAllBuyers();
        [OperationContract]
        void UpdateBuyer(Buyer buyer, List<Property> properties, string name, string address, Location location, string phone, string mobil, string email, string misc, string estateType, double minPrice, double maxPrice, double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<Location> desiredLocations, string otherPref, Boolean contactAllowedByBoligOne, Boolean contactAllowedByReal, Boolean allowedEmailSpam, Boolean inRKI, Boolean buyerApproved, string bank, Boolean ownesHouse, Boolean livesForRent);
        [OperationContract]
        void DeleteBuyer(Buyer buyer);
    }
}
