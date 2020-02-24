using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("ChatbotQuestionType")]
    public class ChatbotQuestionType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
