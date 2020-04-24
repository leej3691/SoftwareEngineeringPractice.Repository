namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReferenceKeyChatbot : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatbotQuestions", "ReferenceKey", c => c.String());
            AddColumn("dbo.ChatbotQuestionsLive", "ReferenceKey", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatbotQuestionsLive", "ReferenceKey");
            DropColumn("dbo.ChatbotQuestions", "ReferenceKey");
        }
    }
}
