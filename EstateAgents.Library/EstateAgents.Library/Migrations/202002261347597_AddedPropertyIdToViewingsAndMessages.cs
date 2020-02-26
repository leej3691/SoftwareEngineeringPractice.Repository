namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropertyIdToViewingsAndMessages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "PropertyId", c => c.Int(nullable: false));
            AddColumn("dbo.PropertyViewings", "PropertyId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PropertyViewings", "PropertyId");
            DropColumn("dbo.Messages", "PropertyId");
        }
    }
}
