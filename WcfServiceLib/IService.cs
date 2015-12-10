using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace WcfServiceLib
{
    [ServiceContract]
    public interface IService
    {
        //Appointment contracts
        [OperationContract]
        void InsertAppointment(Appointment appointment);
        [OperationContract]
        List<Appointment> GetAppointment(DateTime date);
        [OperationContract]
        List<Appointment> GetAllAppointments();
        [OperationContract]
        void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime,
            string category, string descricption, string status, Seller seller, Buyer buyer);
        [OperationContract]
        void DeleteAppointment(Appointment appointment);

        //Buyer contracts
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
        void UpdateBuyerSingle(Buyer buyer);
        [OperationContract]
        void DeleteBuyer(Buyer buyer);

        //Location contracts
        [OperationContract]
        void InsertLocation(Location location);
        [OperationContract]
        Location GetLocation(string zipCode);
        [OperationContract]
        List<Location> GetLocationsByCity(string city);
        [OperationContract]
        List<Location> GetAllLocations();
        [OperationContract]
        void UpdateLocation(Location loc, string zipCode, string city);
        [OperationContract]
        void DeleteLocation(Location loc);

        //Property contracts
        [OperationContract]
        void InsertProperty(Property property);
        [OperationContract]
        Property GetProperty(string address);
        [OperationContract]
        List<Property> GetPropertiesByAddress(string address);
        [OperationContract]
        List<Property> GetAllProperties();
        [OperationContract]
        void UpdateProperty(Property property, string address, string zipCode, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear);
        [OperationContract]
        void DeleteProperty(Property property);
        [OperationContract]
        Property GetPropertyBySellerID(int sellerID);

        //Seller contracts
        [OperationContract]
        void InsertSeller(Seller seller);
        [OperationContract]
        Seller GetSellerById(int id);
        [OperationContract]
        Seller GetSellerByPhone(string phone);
        [OperationContract]
        Seller GetSellerByMobile(string mobile);
        [OperationContract]
        List<Seller> GetAllSellers();
        [OperationContract]
        void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc);
        [OperationContract]
        void DeleteSeller(Seller seller);
        [OperationContract]
        void AddPropertyToSeller(Seller seller, Property property);
        [OperationContract]
        List<Property> GetAllPropertiesFromSeller(Seller seller);

        //User contracts
        [OperationContract]
        void InsertUser(User user);

        [OperationContract]
        User GetUserUserByPhone(string phone);

        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        void UpdateUser(User user, List<Appointment> appointments, string name, string address, string zipCode, string phone, string mobil, string email, string misc);

        [OperationContract]
        void DeleteUser(User user);

        [OperationContract]
        Buyer GetBuyerById(int id);
    }
}
