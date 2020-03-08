namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViewingStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyViewingStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PropertyViewings", "PropertyViewingStatusId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PropertyViewings", "PropertyViewingStatusId");
            DropTable("dbo.PropertyViewingStatus");
        }
    }
}
