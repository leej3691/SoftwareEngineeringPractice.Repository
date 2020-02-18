using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("PropertySaved")]
    public class PropertySaved
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PropertyId { get; set; }
        public bool Saved { get; set; }
    }
}
