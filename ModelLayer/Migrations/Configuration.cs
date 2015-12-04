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
<<<<<<< HEAD
                    new Seller { Name = "SellerTest" + i, Address = "Address" + i, ZipCode = "9000", Email = "Email" + i + "@testmail.dk", Phone = "1000" + i.ToString(), Mobile = "2000" + i.ToString() }
=======
                    new Seller { Name = "SellerTest" + i, Address = "Address" + i, ZipCode = "9000", Email = "Email" + i + "@testmail.dk", Phone = Convert.ToString(i + 1000), Mobile = Convert.ToString(i + 2000) }
>>>>>>> origin/master
                    );
            }

            for (int i = 1; i < 5; i++)
            {
                context.Buyers.AddOrUpdate(
<<<<<<< HEAD
                    new Buyer { Name = "BuyerTest" + i, Address = "Address" + (i + 5), ZipCode = "9000", Email = "Email" + (i + 5) + "@testmail.dk", Phone = "3000" + i.ToString(), Mobile = "4000" + i.ToString() }
=======
                    new Buyer
                    {
                        Name = "BuyerTest" + i,
                        Address = "Address" + (i + 5),
                        ZipCode = "9000",
                        Email = "Email" + (i + 5) + "@testmail.dk",
                        Phone = Convert.ToString(i + 3000),
                        Mobile = Convert.ToString(i + 4000),
                        AllowedEmailSpam = true,
                        BuyerApproved = true,
                        Bank = "Bank nr. " + i,
                        ApprovedAmount = i * 150000,
                        ContactAllowedByBoligOne = true,
                        ContactAllowedByReal = true,
                        EstateType = "Hus",
                        InRKI = false,
                        LivesForRent = false,
                        OwnesHouse = true,
                        LotSizeMax = 200 * i,
                        LotSizeMin = 180 * i,
                        MinPrice = 200000 * i,
                        MaxPrice = 300000 * i,
                        DesiredRoomsMin = 2 + i,
                        DesiredRoomsMax = 3 + i,
                        ProbertySizeMin = 40 * i,
                        ProbertySizeMax = 55 * i,
                        OtherPref = "Andre ting" + i,
                        Misc = "Forskellige ting" + i
                    }
                    );
            }
            for (int i = 1; i < 30; i++)
            {
                DateTime date = new DateTime(2015, 12, i);
                DateTime startTime = new DateTime(2015, 12, i, 12, 0, 0);
                DateTime endTime = new DateTime(2015, 12, i, 13, 0, 0);
                context.Appointments.AddOrUpdate(
                    new Appointment { Date = date, StarTime = startTime, EndTime = endTime, Category = "Kategori", Description = "Beskri" + i, Status = "status" + i }
>>>>>>> origin/master
                    );
            }
            //for (int i = 1; i < 5; i++)
            //{
            //    context.Properties.AddOrUpdate(
            //        new Property
            //        {
            //            Address = "Adresse" + (i + 5),
            //            ZipCode = "9000",
            //            Type = "Hus",
            //            Rooms = (i + 3),
            //            Floors = i,
            //            PropertySize = (234 * i),
            //            HouseSize = (23 * i),
            //            Price = (100000 * i),
            //            ConstructionYear = (1975 + i),
            //            SellerID = i
            //        }
            //        );
            //}
        }
    }
}
