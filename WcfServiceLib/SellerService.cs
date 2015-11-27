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
    public class SellerService : ISellerService
    {
        static SellerController sCtr = new SellerController();
        public List<Seller> GetAllSellers()
        {
            return sCtr.GetAllSellers();
        }
    }
}
