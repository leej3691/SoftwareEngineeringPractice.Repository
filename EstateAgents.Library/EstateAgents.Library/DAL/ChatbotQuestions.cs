using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("ChatbotQuestions")]
    public class ChatbotQuestions
    {
        [Key]
        public int Id { get; set; }
        public int ChatbotQuestionTypeId { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public string ReferenceKey { get; set; }
    }
}
