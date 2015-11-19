namespace ModelLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        StarTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Category = c.String(),
                        Description = c.String(),
                        Status = c.String(),
                        Buyer_Id = c.Int(),
                        Seller_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.Buyer_Id)
                .ForeignKey("dbo.Sellers", t => t.Seller_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Buyer_Id)
                .Index(t => t.Seller_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstateType = c.String(),
                        MinPrice = c.Double(nullable: false),
                        MaxPrice = c.Double(nullable: false),
                        LotSizeMin = c.Double(nullable: false),
                        LotSizeMax = c.Double(nullable: false),
                        ProbertySizeMin = c.Double(nullable: false),
                        ProbertySizeMax = c.Double(nullable: false),
                        DesiredRoomsMin = c.Double(nullable: false),
                        DesiredRoomsMax = c.Double(nullable: false),
                        OtherPref = c.String(),
                        ContactAllowedByBoligOne = c.Boolean(nullable: false),
                        ContactAllowedByReal = c.Boolean(nullable: false),
                        AllowedEmailSpam = c.Boolean(nullable: false),
                        InRKI = c.Boolean(nullable: false),
                        BuyerApproved = c.Boolean(nullable: false),
                        Bank = c.String(),
                        OwnesHouse = c.Boolean(nullable: false),
                        LivesForRent = c.Boolean(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Mobil = c.String(),
                        Email = c.String(),
                        Misc = c.String(),
                        Location_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZipCode = c.String(),
                        City = c.String(),
                        Buyer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.Buyer_Id)
                .Index(t => t.Buyer_Id);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Type = c.String(),
                        Rooms = c.Int(nullable: false),
                        Floors = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        PropertySize = c.Double(nullable: false),
                        HouseSize = c.Double(nullable: false),
                        ConstructionYear = c.Int(nullable: false),
                        Location_Id = c.Int(),
                        Buyer_Id = c.Int(),
                        Seller_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .ForeignKey("dbo.Buyers", t => t.Buyer_Id)
                .ForeignKey("dbo.Sellers", t => t.Seller_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.Buyer_Id)
                .Index(t => t.Seller_Id);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Mobil = c.String(),
                        Email = c.String(),
                        Misc = c.String(),
                        Location_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Mobil = c.String(),
                        Email = c.String(),
                        Misc = c.String(),
                        Location_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .Index(t => t.Location_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Appointments", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Appointments", "Seller_Id", "dbo.Sellers");
            DropForeignKey("dbo.Properties", "Seller_Id", "dbo.Sellers");
            DropForeignKey("dbo.Sellers", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Appointments", "Buyer_Id", "dbo.Buyers");
            DropForeignKey("dbo.Properties", "Buyer_Id", "dbo.Buyers");
            DropForeignKey("dbo.Properties", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Buyers", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.Users", new[] { "Location_Id" });
            DropIndex("dbo.Sellers", new[] { "Location_Id" });
            DropIndex("dbo.Properties", new[] { "Seller_Id" });
            DropIndex("dbo.Properties", new[] { "Buyer_Id" });
            DropIndex("dbo.Properties", new[] { "Location_Id" });
            DropIndex("dbo.Locations", new[] { "Buyer_Id" });
            DropIndex("dbo.Buyers", new[] { "Location_Id" });
            DropIndex("dbo.Appointments", new[] { "User_Id" });
            DropIndex("dbo.Appointments", new[] { "Seller_Id" });
            DropIndex("dbo.Appointments", new[] { "Buyer_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Sellers");
            DropTable("dbo.Properties");
            DropTable("dbo.Locations");
            DropTable("dbo.Buyers");
            DropTable("dbo.Appointments");
        }
    }
}
