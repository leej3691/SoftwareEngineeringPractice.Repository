namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEnquiryPropertyViewingsAndPropertyFeatures : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enquiry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Forename = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        Email = c.String(maxLength: 250),
                        Mobile = c.String(maxLength: 11),
                        EnquiryBody = c.String(),
                        StaffMemberId = c.Int(),
                        StaffMemberProcessed = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyFeatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Deleted = c.DateTime(),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyViewings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Cancelled = c.DateTime(),
                        ViewingDate = c.DateTime(nullable: false),
                        ViewingTime = c.String(maxLength: 5),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PropertyViewings");
            DropTable("dbo.PropertyFeatures");
            DropTable("dbo.Enquiry");
        }
    }
}
