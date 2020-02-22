using EstateAgents.Library.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertySearchViewModel
    {
        /// <summary>
        /// The property sale type to search
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Property Sale Type")]
        [Required(ErrorMessage = "Please provide the property sale type.")]
        public PropertySaleType? PropertySaleType { get; set; }

        /// <summary>
        /// The property type to search
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Property Type")]
        [Required(ErrorMessage = "Please provide the property type.")]
        public PropertyType? PropertyType { get; set; }

        /// <summary>
        /// The location to search
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Location")]
        [Required(ErrorMessage = "Please provide a location.")]
        [MaxLength(50, ErrorMessage = "The location must be less than 50 characters")]
        public string Location { get; set; }

        /// <summary>
        /// The number of bedrooms to search
        /// </summary>
        [UIHint("NumberInput")]
        [DisplayName("Number of Bedrooms")]
        [Required(ErrorMessage = "Please provide number of bedrooms.")]
        public int NumberOfBedrooms { get; set; }

        /// <summary>
        /// Include sold properties
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Include Sold Properties")]
        [Required(ErrorMessage = "Please include sold properties.")]
        public YesNo? IncludeSoldProperties { get; set; }

        /// <summary>
        /// The price from to search
        /// </summary>
        [UIHint("DecimalInput")]
        [DisplayName("Price From")]
        [Required(ErrorMessage = "Please provide a price from.")]
        public decimal PriceFrom { get; set; }

        /// <summary>
        /// The price to to search
        /// </summary>
        [UIHint("DecimalInput")]
        [DisplayName("Price To")]
        [Required(ErrorMessage = "Please provide a price to.")]
        public decimal PriceTo { get; set; }

    }
}