namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPostedAndClosedDatesToProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Property", "PostedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Property", "ClosedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Property", "ClosedDate");
            DropColumn("dbo.Property", "PostedDate");
        }
    }
}
