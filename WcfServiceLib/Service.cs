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
    public class Service : IService
    {
        static AppointmentController aCtr = new AppointmentController();
        static BuyerController bCtr = new BuyerController();
        static LocationController lCtr = new LocationController();
        static PropertyController pCtr = new PropertyController();
        static SellerController sCtr = new SellerController();
        static UserController uCtr = new UserController();

        #region Appointment
        public void InsertAppointment(Appointment appointment, Buyer buyer, Seller seller)
        {
            aCtr.InsertAppointment(appointment, buyer, seller);
        }

        public List<Appointment> GetAppointment(DateTime date)
        {
            return aCtr.GetAppointment(date);
        }

        public List<Appointment> GetAllAppointments()
        {
            return aCtr.GetAllAppointments();
        }

        public void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime, string category, string descricption, string status, ModelLayer.Seller seller, ModelLayer.Buyer buyer)
        {
            aCtr.UpdateAppointment(appointment, date, StartTime, EndTime, category, descricption, status, seller, buyer);
        }

        public void DeleteAppointment(ModelLayer.Appointment appointment)
        {
            aCtr.DeleteAppointment(appointment);
        }
        #endregion

        #region Buyer
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
            bCtr.UpdateBuyer(buyer, properties, name, address, zipCode, phone, mobil, email,
                             misc, estateType, minPrice, maxPrice, lotSizeMin, lotSizeMax, 
                             probertySizeMin, probertySizeMax, desiredRoomsMin, desiredRoomsMax, 
                             desiredLocations, otherPref, contactAllowedByBoligOne, contactAllowedByReal, 
                             allowedEmailSpam, inRKI, buyerApproved, bank, ownesHouse, livesForRent);
        }

        public void DeleteBuyer(Buyer buyer)
        {
            bCtr.DeleteBuyer(buyer);
        }
        #endregion

        #region Location
        public void InsertLocation(Location location)
        {
            lCtr.InsertLocation(location);
        }

        public Location GetLocation(string zipCode)
        {
            return lCtr.GetLocation(zipCode);
        }

        public List<Location> GetLocationsByCity(string city)
        {
            return lCtr.GetLocationsByCity(city);
        }

        public List<Location> GetAllLocations()
        {
            return lCtr.GetAllLocations();
        }

        public void UpdateLocation(Location loc, string zipCode, string city)
        {
            lCtr.UpdateLocation(loc, zipCode, city);
        }

        public void DeleteLocation(Location loc)
        {
            lCtr.DeleteLocation(loc);
        }
        #endregion

        #region Property
        public void InsertProperty(Property property)
        {
            pCtr.InsertProperty(property);
        }

        public List<Property> GetPropertiesByAddress(string address)
        {
            return pCtr.GetPropertyByAddress(address);
        }

        public List<Property> GetAllProperties()
        {
            return pCtr.GetAllProperties();
        }

        public void UpdateProperty(Property property, string address, string zipCode, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear)
        {
            pCtr.UpdateProperty(property, address, zipCode, type, rooms, floors, price, propertySize, houseSize, constructionYear);
        }

        public void DeleteProperty(Property property)
        {
            pCtr.DeleteProperty(property);
        }

        public Property GetProperty(string address)
        {
            return pCtr.GetProperty(address);
        }


        public Property GetPropertyBySellerID(int sellerID)
        {
            return pCtr.GetPropertyBySellerID(sellerID);
        }
        #endregion

        #region Seller
        public void InsertSeller(Seller seller)
        {
            sCtr.InsertSeller(seller);
        }

        public Seller GetSellerByPhone(string phone)
        {
            return sCtr.GetSellerByPhone(phone);
        }

        public Seller GetSellerByMobile(string mobile)
        {
            return sCtr.GetSellerByMobile(mobile);
        }

        public List<Seller> GetAllSellers()
        {
            return sCtr.GetAllSellers();
        }

        public void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            sCtr.UpdateSeller(seller, properties, name, address, zipCode, phone, mobil, email, misc);
        }

        public void DeleteSeller(Seller seller)
        {
            sCtr.DeleteSeller(seller);
        }
        public void AddPropertyToSeller(Seller seller, Property property)
        {
            sCtr.AddPropertyToSeller(seller, property);
        }
        public List<Property> GetAllPropertiesFromSeller(Seller seller)
        {
            return sCtr.GetAllProperties(seller);
        }
        public Seller GetSellerById(int id)
        {
            return sCtr.GetSellerById(id);
        }
        #endregion

        #region User
        public void InsertUser(User user)
        {
            uCtr.InsertUser(user);
        }

        public User GetUserUserByPhone(string phone)
        {
            return uCtr.GetUserByPhone(phone);
        }

        public User GetUserById(int id)
        {
            return uCtr.GetUserById(id);
        }

        public List<User> GetAllUsers()
        {
            return uCtr.GetAllUsers();
        }

        public void UpdateUser(User user, List<Appointment> appointments, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            uCtr.UpdateUser(user, appointments, name, address, zipCode, phone, mobil, email, misc);
        }

        public void DeleteUser(User user)
        {
            uCtr.DeleteUser(user);
        }
        #endregion
    }
}