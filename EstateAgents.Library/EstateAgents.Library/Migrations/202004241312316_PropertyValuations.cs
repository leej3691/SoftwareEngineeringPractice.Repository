namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyValuations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyValuations",
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PropertyValuations");
        }
    }
}
