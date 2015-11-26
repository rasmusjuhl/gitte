namespace ModelLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedzipcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buyers", "ZipCode", c => c.String());
            AddColumn("dbo.Properties", "ZipCode", c => c.String());
            AddColumn("dbo.Sellers", "ZipCode", c => c.String());
            AddColumn("dbo.Users", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ZipCode");
            DropColumn("dbo.Sellers", "ZipCode");
            DropColumn("dbo.Properties", "ZipCode");
            DropColumn("dbo.Buyers", "ZipCode");
        }
    }
}
