namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 5),
                        Forename = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        AddressLine1 = c.String(maxLength: 100),
                        AddressLine2 = c.String(maxLength: 100),
                        AddressLine3 = c.String(maxLength: 100),
                        AddressLine4 = c.String(maxLength: 100),
                        AddressLine5 = c.String(maxLength: 100),
                        Postcode = c.String(maxLength: 10),
                        Email = c.String(maxLength: 250),
                        Mobile = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 5),
                        Forename = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        AddressLine1 = c.String(maxLength: 100),
                        AddressLine2 = c.String(maxLength: 100),
                        AddressLine3 = c.String(maxLength: 100),
                        AddressLine4 = c.String(maxLength: 100),
                        AddressLine5 = c.String(maxLength: 100),
                        Postcode = c.String(maxLength: 10),
                        Email = c.String(maxLength: 250),
                        Mobile = c.String(maxLength: 11),
                        JobTitleId = c.Int(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateLeft = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeJobTitle",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        MessageBody = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        MessageTime = c.String(maxLength: 10),
                        StaffResponse = c.Boolean(nullable: false),
                        Read = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Property",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PropertySaleTypeId = c.Int(nullable: false),
                        PropertyStatusId = c.Int(nullable: false),
                        PropertyTypeId = c.Int(nullable: false),
                        PropertyPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddressLine1 = c.String(maxLength: 100),
                        AddressLine2 = c.String(maxLength: 100),
                        AddressLine3 = c.String(maxLength: 100),
                        AddressLine4 = c.String(maxLength: 100),
                        AddressLine5 = c.String(maxLength: 100),
                        Postcode = c.String(maxLength: 10),
                        NumberOfBedrooms = c.Int(nullable: false),
                        NumberOfBathrooms = c.Int(nullable: false),
                        Ensuite = c.Boolean(nullable: false),
                        Garage = c.Boolean(nullable: false),
                        Garden = c.Boolean(nullable: false),
                        Driveway = c.Boolean(nullable: false),
                        CentralHeating = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Deleted = c.DateTime(),
                        PropertyId = c.Int(nullable: false),
                        Description = c.String(maxLength: 50),
                        ImageData = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertySaleType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertySaved",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        Saved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PropertyType");
            DropTable("dbo.PropertyStatus");
            DropTable("dbo.PropertySaved");
            DropTable("dbo.PropertySaleType");
            DropTable("dbo.PropertyImages");
            DropTable("dbo.Property");
            DropTable("dbo.Messages");
            DropTable("dbo.EmployeeJobTitle");
            DropTable("dbo.Employee");
            DropTable("dbo.Client");
        }
    }
}
