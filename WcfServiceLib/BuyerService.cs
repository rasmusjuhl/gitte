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
        public List<Buyer> GetAllBuyers()
        {
            bCtr.GetAllBuyers();
        }
    }
}
