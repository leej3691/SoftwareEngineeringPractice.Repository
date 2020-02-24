namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyIdAddedToPropertyFeatures : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyFeatures", "PropertyId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PropertyFeatures", "PropertyId");
        }
    }
}
