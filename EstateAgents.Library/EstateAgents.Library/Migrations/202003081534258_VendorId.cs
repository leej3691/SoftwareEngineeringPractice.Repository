namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VendorId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Property", "VendorClientId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Property", "VendorClientId");
        }
    }
}
