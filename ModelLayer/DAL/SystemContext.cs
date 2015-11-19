using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DAL
{
    public class SystemContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }

        public SystemContext() : base("local")
    {
            
    }
    }
}
