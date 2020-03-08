namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Client", "ClientTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "ClientTypeId");
            DropTable("dbo.ClientType");
        }
    }
}
