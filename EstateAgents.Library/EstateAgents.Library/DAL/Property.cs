using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstateAgents.Library.DAL
{
    [Table("Property")]
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public int PropertySaleTypeId { get; set; }
        public int PropertyStatusId { get; set; }
        public int PropertyTypeId { get; set; }
        public decimal PropertyPrice { get; set; }
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
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string AdditionalDetails { get; set; }
    }
}
