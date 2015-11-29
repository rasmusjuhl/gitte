using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;

namespace WcfServiceLib
{
    [ServiceContract]
    public interface IBuyerService
    {
        [OperationContract]
        void InsertBuyer(Buyer buyer);
        [OperationContract]
        Buyer GetBuyerByPhone(string phone);
        [OperationContract]
        Buyer GetBuyerByMobile(string mobile);
        [OperationContract]
        List<Buyer> GetAllBuyers();
        [OperationContract]
        List<Location> GetAllLocationsByPhone(string phone);
        [OperationContract]
        List<Location> GetAllLocationsByMobile(string mobile);
        [OperationContract]
        List<Property> GetAllPropertiesByPhone(string phone);
        [OperationContract]
        List<Property> GetAllPropertiesByMobile(string mobile);
        [OperationContract]
        void UpdateBuyer(Buyer buyer, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc, string estateType, double minPrice, double maxPrice, double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<Location> desiredLocations, string otherPref, Boolean contactAllowedByBoligOne, Boolean contactAllowedByReal, Boolean allowedEmailSpam, Boolean inRKI, Boolean buyerApproved, string bank, Boolean ownesHouse, Boolean livesForRent);
        [OperationContract]
        void DeleteBuyer(Buyer buyer);
    }
}
