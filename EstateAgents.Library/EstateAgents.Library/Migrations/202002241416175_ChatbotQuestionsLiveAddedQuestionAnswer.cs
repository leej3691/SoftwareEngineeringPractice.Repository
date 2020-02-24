namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatbotQuestionsLiveAddedQuestionAnswer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChatbotQuestionsLive", "QuestionAnswer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChatbotQuestionsLive", "QuestionAnswer");
        }
    }
}
