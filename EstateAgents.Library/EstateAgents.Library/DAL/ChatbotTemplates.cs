using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("ChatbotTemplates")]
    public class ChatbotTemplates
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
