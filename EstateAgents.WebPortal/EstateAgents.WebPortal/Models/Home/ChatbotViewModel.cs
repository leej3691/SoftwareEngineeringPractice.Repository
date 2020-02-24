using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.WebPortal.Models.Home
{
    public class ChatbotViewModel
    {
        public List<ChatbotQuestionsLive> ChatbotQuestionsLive { get; set; }
        public List<ChatbotQuestionsLive> ChatbotCurrentQuestion { get; set; }

        public ChatbotViewModel()
        {
            this.ChatbotQuestionsLive = new List<ChatbotQuestionsLive>();
            this.ChatbotCurrentQuestion = new List<ChatbotQuestionsLive>();
        }

        public ChatbotViewModel(int TemplateId)
        {
            this.ChatbotQuestionsLive = EstateAgentsRepository.GetChatbotQuestionsLiveByTemplateIdAndQuestionAsked(TemplateId);
            this.ChatbotCurrentQuestion = EstateAgentsRepository.GetChatbotQuestionsLiveCurrentQuestions(TemplateId);
        }
    }
}