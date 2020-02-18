using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("PropertyType")]
    public class PropertyType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
    }
}
