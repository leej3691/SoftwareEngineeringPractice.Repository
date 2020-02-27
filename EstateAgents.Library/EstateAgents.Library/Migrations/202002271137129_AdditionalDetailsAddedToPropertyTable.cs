namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalDetailsAddedToPropertyTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Property", "AdditionalDetails", c => c.String());
            DropColumn("dbo.Property", "Ensuite");
            DropColumn("dbo.Property", "Garage");
            DropColumn("dbo.Property", "Garden");
            DropColumn("dbo.Property", "Driveway");
            DropColumn("dbo.Property", "CentralHeating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Property", "CentralHeating", c => c.Boolean(nullable: false));
            AddColumn("dbo.Property", "Driveway", c => c.Boolean(nullable: false));
            AddColumn("dbo.Property", "Garden", c => c.Boolean(nullable: false));
            AddColumn("dbo.Property", "Garage", c => c.Boolean(nullable: false));
            AddColumn("dbo.Property", "Ensuite", c => c.Boolean(nullable: false));
            DropColumn("dbo.Property", "AdditionalDetails");
        }
    }
}
