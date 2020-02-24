using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("Enquiry")]
    public class Enquiry
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [StringLength(50)]
        public string Forename { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(11)]
        public string Mobile { get; set; }
        public string EnquiryBody { get; set; }
        public int? StaffMemberId { get; set; }
        public DateTime? StaffMemberProcessed { get; set; }
    }
}
