namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StaffProcessedMessages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "StaffProcessed", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "StaffProcessed");
        }
    }
}
