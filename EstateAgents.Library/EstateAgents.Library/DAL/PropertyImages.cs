using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("PropertyImages")]
    public class PropertyImages
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Deleted { get; set; }
        public int PropertyId { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public byte[] ImageData { get; set; }
    }
}
