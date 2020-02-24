namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatbotSequence : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatbotQuestions", "Sequence", c => c.Int(nullable: false));
            AddColumn("dbo.ChatbotQuestionsLive", "Sequence", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatbotQuestionsLive", "Sequence");
            DropColumn("dbo.ChatbotQuestions", "Sequence");
        }
    }
}
