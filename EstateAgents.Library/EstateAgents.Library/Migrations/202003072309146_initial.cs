namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatbotQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChatbotQuestionTypeId = c.Int(nullable: false),
                        Description = c.String(),
                        Sequence = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChatbotQuestionsLive",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChatbotTemplateId = c.Int(nullable: false),
                        ChatbotQuestionTypeId = c.Int(nullable: false),
                        Description = c.String(),
                        QuestionAskedDate = c.DateTime(),
                        QuestionAskedTime = c.String(),
                        QuestionAnswerDate = c.DateTime(),
                        QuestionAnswerTime = c.String(),
                        QuestionAnswer = c.String(),
                        Sequence = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChatbotQuestionType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChatbotTemplates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartedDate = c.DateTime(nullable: false),
                        CompletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        UserId = c.Guid(nullable: false),
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
                        UserId = c.Guid(nullable: false),
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
                        PropertyId = c.Int(nullable: false),
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
                        PostedDate = c.DateTime(nullable: false),
                        ClosedDate = c.DateTime(),
                        AdditionalDetails = c.String(),
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
                        PropertyId = c.Int(nullable: false),
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
                        PropertyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
           
            
            //CreateTable(
            //    "dbo.AspNetUserRoles",
            //    c => new
            //        {
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            RoleId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.UserId, t.RoleId })
            //    .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId)
            //    .Index(t => t.RoleId);
            
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            //CreateTable(
            //    "dbo.AspNetUserClaims",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            ClaimType = c.String(),
            //            ClaimValue = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.AspNetUserLogins",
            //    c => new
            //        {
            //            LoginProvider = c.String(nullable: false, maxLength: 128),
            //            ProviderKey = c.String(nullable: false, maxLength: 128),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PropertyViewings");
            DropTable("dbo.PropertyType");
            DropTable("dbo.PropertyStatus");
            DropTable("dbo.PropertySaved");
            DropTable("dbo.PropertySaleType");
            DropTable("dbo.PropertyOfferStatus");
            DropTable("dbo.PropertyOffers");
            DropTable("dbo.PropertyImages");
            DropTable("dbo.PropertyFeatures");
            DropTable("dbo.Property");
            DropTable("dbo.Messages");
            DropTable("dbo.Enquiry");
            DropTable("dbo.EmployeeJobTitle");
            DropTable("dbo.Employee");
            DropTable("dbo.Client");
            DropTable("dbo.ChatbotTemplates");
            DropTable("dbo.ChatbotQuestionType");
            DropTable("dbo.ChatbotQuestionsLive");
            DropTable("dbo.ChatbotQuestions");
        }
    }
}
