using ModelLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SystemContext())
            {
                Location loc = new Location() { ZipCode = "9000", City = "Aarhus" };
                ctx.Locations.Add(loc);
                
                Console.WriteLine(loc.ZipCode + " " + loc.City);
                Seller seller = new Seller() { Name = "Hans" };
                ctx.Sellers.Add(seller);
                User user = new User() { Name = "Peter" };
                ctx.Users.Add(user);
                Buyer buyer = new Buyer() { Name = "Fucking Jens" };
                ctx.Buyers.Add(buyer);
                ctx.SaveChanges();
            }



        }
    }
}
