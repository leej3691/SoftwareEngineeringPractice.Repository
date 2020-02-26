using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("Messages")]
    public class Messages
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        [StringLength(5000)]
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
        [StringLength(10)]
        public string MessageTime { get; set; }
        public bool StaffResponse { get; set; }
        public bool Read { get; set; }
        public int PropertyId { get; set; }
    }
}
