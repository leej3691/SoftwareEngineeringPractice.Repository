namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserIdToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "UserId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "UserId");
        }
    }
}
