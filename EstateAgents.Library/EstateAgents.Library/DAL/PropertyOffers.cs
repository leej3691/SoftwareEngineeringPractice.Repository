using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("PropertyOffers")]
    public class PropertyOffers
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Cancelled { get; set; }
        public int ClientId { get; set; }
        public int PropertyId { get; set; }
        public decimal OfferAmount { get; set; }
        public int PropertyOfferStatusId { get; set; }
    }
}
