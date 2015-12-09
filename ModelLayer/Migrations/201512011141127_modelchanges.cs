namespace ModelLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Properties", "Seller_Id", "dbo.Sellers");
            DropIndex("dbo.Properties", new[] { "Seller_Id" });
            RenameColumn(table: "dbo.Properties", name: "Seller_Id", newName: "SellerID");
            AddColumn("dbo.Buyers", "ApprovedAmount", c => c.Double(nullable: false));
            AlterColumn("dbo.Properties", "SellerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Properties", "SellerID");
            AddForeignKey("dbo.Properties", "SellerID", "dbo.Sellers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Properties", "SellerID", "dbo.Sellers");
            DropIndex("dbo.Properties", new[] { "SellerID" });
            AlterColumn("dbo.Properties", "SellerID", c => c.Int());
            DropColumn("dbo.Buyers", "ApprovedAmount");
            RenameColumn(table: "dbo.Properties", name: "SellerID", newName: "Seller_Id");
            CreateIndex("dbo.Properties", "Seller_Id");
            AddForeignKey("dbo.Properties", "Seller_Id", "dbo.Sellers", "Id");
        }
    }
}
