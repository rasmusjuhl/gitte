using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface ISellerService
    {
        [OperationContract]
        void InsertSeller(Seller seller);
        [OperationContract]
        Seller GetSellerByPhone(string phone);
        [OperationContract]
        List<Seller> GetAllSellers();
        [OperationContract]
        void UpdateSeller(Seller seller, List<Property> properties, string name, string address, string zipCode, Location location, string phone, string mobil, string email, string misc);
        [OperationContract]
        void DeleteSeller(Seller seller);
    }
}
