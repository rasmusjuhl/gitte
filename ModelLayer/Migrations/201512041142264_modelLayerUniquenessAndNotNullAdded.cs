namespace ModelLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelLayerUniquenessAndNotNullAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Properties", "Seller_Id", "dbo.Sellers");
            DropForeignKey("dbo.Appointments", "User_Id", "dbo.Users");
            DropIndex("dbo.Appointments", new[] { "User_Id" });
            DropIndex("dbo.Properties", new[] { "Seller_Id" });
            RenameColumn(table: "dbo.Properties", name: "Seller_Id", newName: "SellerID");
            RenameColumn(table: "dbo.Appointments", name: "User_Id", newName: "UserID");
            AddColumn("dbo.Buyers", "ApprovedAmount", c => c.Double(nullable: false));
            AlterColumn("dbo.Appointments", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Buyers", "Phone", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Buyers", "Mobile", c => c.String(maxLength: 450));
            AlterColumn("dbo.Locations", "ZipCode", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Properties", "Address", c => c.String(maxLength: 450));
            AlterColumn("dbo.Properties", "ZipCode", c => c.String(maxLength: 450));
            AlterColumn("dbo.Properties", "SellerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Sellers", "Phone", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Sellers", "Mobile", c => c.String(maxLength: 450));
            AlterColumn("dbo.Users", "Phone", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Users", "Mobile", c => c.String(maxLength: 450));
            CreateIndex("dbo.Appointments", new[] { "Date", "StarTime", "UserID" }, unique: true, name: "DateStartAndUserID");
            CreateIndex("dbo.Buyers", "Phone", unique: true);
            CreateIndex("dbo.Buyers", "Mobile", unique: true);
            CreateIndex("dbo.Locations", "ZipCode", unique: true);
            CreateIndex("dbo.Properties", new[] { "Address", "ZipCode" }, unique: true, name: "AddresseAndZipCode");
            CreateIndex("dbo.Properties", "SellerID");
            CreateIndex("dbo.Sellers", "Phone", unique: true);
            CreateIndex("dbo.Sellers", "Mobile", unique: true);
            CreateIndex("dbo.Users", "Phone", unique: true);
            CreateIndex("dbo.Users", "Mobile", unique: true);
            AddForeignKey("dbo.Properties", "SellerID", "dbo.Sellers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "UserID", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "UserID", "dbo.Users");
            DropForeignKey("dbo.Properties", "SellerID", "dbo.Sellers");
            DropIndex("dbo.Users", new[] { "Mobile" });
            DropIndex("dbo.Users", new[] { "Phone" });
            DropIndex("dbo.Sellers", new[] { "Mobile" });
            DropIndex("dbo.Sellers", new[] { "Phone" });
            DropIndex("dbo.Properties", new[] { "SellerID" });
            DropIndex("dbo.Properties", "AddresseAndZipCode");
            DropIndex("dbo.Locations", new[] { "ZipCode" });
            DropIndex("dbo.Buyers", new[] { "Mobile" });
            DropIndex("dbo.Buyers", new[] { "Phone" });
            DropIndex("dbo.Appointments", "DateStartAndUserID");
            AlterColumn("dbo.Users", "Mobile", c => c.String());
            AlterColumn("dbo.Users", "Phone", c => c.String());
            AlterColumn("dbo.Sellers", "Mobile", c => c.String());
            AlterColumn("dbo.Sellers", "Phone", c => c.String());
            AlterColumn("dbo.Properties", "SellerID", c => c.Int());
            AlterColumn("dbo.Properties", "ZipCode", c => c.String());
            AlterColumn("dbo.Properties", "Address", c => c.String());
            AlterColumn("dbo.Locations", "ZipCode", c => c.String());
            AlterColumn("dbo.Buyers", "Mobile", c => c.String());
            AlterColumn("dbo.Buyers", "Phone", c => c.String());
            AlterColumn("dbo.Appointments", "UserID", c => c.Int());
            DropColumn("dbo.Buyers", "ApprovedAmount");
            RenameColumn(table: "dbo.Appointments", name: "UserID", newName: "User_Id");
            RenameColumn(table: "dbo.Properties", name: "SellerID", newName: "Seller_Id");
            CreateIndex("dbo.Properties", "Seller_Id");
            CreateIndex("dbo.Appointments", "User_Id");
            AddForeignKey("dbo.Appointments", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Properties", "Seller_Id", "dbo.Sellers", "Id");
        }
    }
}
