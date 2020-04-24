using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("PropertyRemovals")]
    public class PropertyRemovals
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Message { get; set; }
        public string PropertyAddressLine1 { get; set; }
        public string PropertyAddressLine2 { get; set; }
        public string PropertyAddressLine3 { get; set; }
        public string PropertyAddressLine4 { get; set; }
        public string PropertyAddressPostcode { get; set; }
        public DateTime? StaffProcessed { get; set; }
    }
}
