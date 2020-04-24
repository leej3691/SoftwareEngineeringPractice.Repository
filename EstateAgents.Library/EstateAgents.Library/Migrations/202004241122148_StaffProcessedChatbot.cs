namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StaffProcessedChatbot : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatbotTemplates", "StaffProcessed", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatbotTemplates", "StaffProcessed");
        }
    }
}
