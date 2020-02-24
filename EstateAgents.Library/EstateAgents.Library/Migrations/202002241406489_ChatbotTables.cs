namespace EstateAgents.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatbotTables : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChatbotTemplates");
            DropTable("dbo.ChatbotQuestionType");
            DropTable("dbo.ChatbotQuestionsLive");
            DropTable("dbo.ChatbotQuestions");
        }
    }
}
