using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("PropertyViewingStatus")]
    public class PropertyViewingStatus
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
    }
}
