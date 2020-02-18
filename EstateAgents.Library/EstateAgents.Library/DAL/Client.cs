using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [StringLength(5)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Forename { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(100)]
        public string AddressLine1 { get; set; }
        [StringLength(100)]
        public string AddressLine2 { get; set; }
        [StringLength(100)]
        public string AddressLine3 { get; set; }
        [StringLength(100)]
        public string AddressLine4 { get; set; }
        [StringLength(100)]
        public string AddressLine5 { get; set; }
        [StringLength(10)]
        public string Postcode { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(11)]
        public string Mobile { get; set; }
    }
}
