namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyRemovals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyRemovals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Message = c.String(),
                        PropertyAddressLine1 = c.String(),
                        PropertyAddressLine2 = c.String(),
                        PropertyAddressLine3 = c.String(),
                        PropertyAddressLine4 = c.String(),
                        PropertyAddressPostcode = c.String(),
                        StaffProcessed = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PropertyRemovals");
        }
    }
}
