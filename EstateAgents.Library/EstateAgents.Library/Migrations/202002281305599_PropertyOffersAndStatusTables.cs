namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyOffersAndStatusTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyOffers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Cancelled = c.DateTime(),
                        ClientId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        OfferAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PropertyOfferStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyOfferStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PropertyOfferStatus");
            DropTable("dbo.PropertyOffers");
        }
    }
}
