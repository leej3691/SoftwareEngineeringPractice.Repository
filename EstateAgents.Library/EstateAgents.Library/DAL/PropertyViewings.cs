using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("PropertyViewings")]
    public class PropertyViewings
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Cancelled { get; set; }
        public DateTime ViewingDate { get; set; }
        [StringLength(5)]
        public string ViewingTime { get; set; }
        public int ClientId { get; set; }
        //public int PropertyId { get; set; }
    }
}
