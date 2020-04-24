using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("ChatbotQuestionsLive")]
    public class ChatbotQuestionsLive
    {
        [Key]
        public int Id { get; set; }
        public int ChatbotTemplateId { get; set; }
        public int ChatbotQuestionTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? QuestionAskedDate { get; set; }
        public string QuestionAskedTime { get; set; }
        public DateTime? QuestionAnswerDate { get; set; }
        public string QuestionAnswerTime { get; set; }
        public string QuestionAnswer { get; set; }
        public int Sequence { get; set; }
        public string ReferenceKey { get; set; }
    }
}
