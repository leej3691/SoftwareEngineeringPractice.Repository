namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StaffProcessPropertyValuations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyValuations", "StaffProcessed", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PropertyValuations", "StaffProcessed");
        }
    }
}
