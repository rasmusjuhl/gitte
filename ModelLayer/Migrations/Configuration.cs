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
                    new User { Name = "UserTest" + i, ZipCode = "9000", Phone = "9999" + i.ToString(), Mobile = "8888" + i.ToString() }
                    );
            }
            for (int i = 1; i < 5; i++)
            {
                context.Sellers.AddOrUpdate(
                    new Seller { Name = "SellerTest" + i, Address = "Address" + i, ZipCode = "9000", Email = "Email" + i + "@testmail.dk", Phone = "1000" + i.ToString(), Mobile = "2000" + i.ToString() }
                    );
            }
            for (int i = 1; i < 5; i++)
            {
                context.Buyers.AddOrUpdate(
                    new Buyer { Name = "BuyerTest" + i, Address = "Address" + (i + 5), ZipCode = "9000", Email = "Email" + (i + 5) + "@testmail.dk", Phone = "3000" + i.ToString(), Mobile = "4000" + i.ToString() }
                    );
            }
        }
    }
}
