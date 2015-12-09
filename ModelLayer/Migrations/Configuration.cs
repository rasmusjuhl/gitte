namespace ModelLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelLayer.DAL.SystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ModelLayer.DAL.SystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Locations.AddOrUpdate(
                new Location { ZipCode = "9000", City = "Aalborg" },
                new Location { ZipCode = "8000", City = "Aarhus" },
                new Location { ZipCode = "8900", City = "Randers" }
                );
            for (int i = 1; i < 5; i++)
            {
                context.Users.AddOrUpdate(
                    new User { Name = "UserTest" + i, ZipCode = "9000", Phone = Convert.ToString(i + 9000), Mobile = Convert.ToString(i + 90000) }
                    );
            }
            for (int i = 1; i < 5; i++)
            {                               
                context.Sellers.AddOrUpdate(
                    new Seller { Name = "SellerTest" + i, Address = "Address" + i, ZipCode = "9000", Email = "Email" + i + "@testmail.dk", Phone = Convert.ToString(i+1000), Mobile= Convert.ToString(i+2000)  }
                    );
            }
            for (int i = 1; i < 5; i++)
            {
                context.Buyers.AddOrUpdate(
                    new Buyer { Name = "BuyerTest" + i, Address = "Address" + (i+5), ZipCode = "9000", Email = "Email" + (i+5) + "@testmail.dk", Phone = Convert.ToString(i + 3000), Mobile = Convert.ToString(i + 4000) }
                    );
            }
            context.Sellers.AddOrUpdate(
                new Seller { Name = "Broder Salsa", Address = "Sofiendalsvej 60", ZipCode = "9000", Mobile = "12345678", Phone = "78945612", Email = "hej@med.dig", Misc = "Random tekst her" }
                );
            //context.Properties.AddOrUpdate(
            //    new Property { Address = "Sofiendalsvej 60", ZipCode = "9000", Floors = 1, Rooms = 5, Price = 1500000, ConstructionYear = 1975, HouseSize = 130, PropertySize = 930, Type = "Hus", SellerID = 5 }
            //    );
        }
    }
}
