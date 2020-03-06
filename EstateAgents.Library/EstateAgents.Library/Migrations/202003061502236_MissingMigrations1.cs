namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MissingMigrations1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "UserId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "UserId");
        }
    }
}
