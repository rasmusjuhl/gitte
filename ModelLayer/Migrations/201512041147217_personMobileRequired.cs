namespace ModelLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personMobileRequired : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Buyers", new[] { "Mobile" });
            DropIndex("dbo.Sellers", new[] { "Mobile" });
            DropIndex("dbo.Users", new[] { "Mobile" });
            AlterColumn("dbo.Buyers", "Mobile", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Sellers", "Mobile", c => c.String(nullable: false, maxLength: 450));
            AlterColumn("dbo.Users", "Mobile", c => c.String(nullable: false, maxLength: 450));
            CreateIndex("dbo.Buyers", "Mobile", unique: true);
            CreateIndex("dbo.Sellers", "Mobile", unique: true);
            CreateIndex("dbo.Users", "Mobile", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Mobile" });
            DropIndex("dbo.Sellers", new[] { "Mobile" });
            DropIndex("dbo.Buyers", new[] { "Mobile" });
            AlterColumn("dbo.Users", "Mobile", c => c.String(maxLength: 450));
            AlterColumn("dbo.Sellers", "Mobile", c => c.String(maxLength: 450));
            AlterColumn("dbo.Buyers", "Mobile", c => c.String(maxLength: 450));
            CreateIndex("dbo.Users", "Mobile", unique: true);
            CreateIndex("dbo.Sellers", "Mobile", unique: true);
            CreateIndex("dbo.Buyers", "Mobile", unique: true);
        }
    }
}
