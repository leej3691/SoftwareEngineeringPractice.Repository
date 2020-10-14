using EstateAgents.Library.Attributes;
using EstateAgents.Library.DAL;
using EstateAgents.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.CMS.Models.PropertyMaintenance
{
    public class UpdatePropertyViewModel
    {
        /// <summary>
        /// The property sale type to search
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Property Sale Type")]
        [Required(ErrorMessage = "Please provide the property sale type.")]
        public Library.Enums.PropertySaleType PropertySaleType { get; set; }

        /// <summary>
        /// The property type to search
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Property Type")]
        [Required(ErrorMessage = "Please provide the property type.")]
        public Library.Enums.PropertyType PropertyType { get; set; }

        /// <summary>
        /// The property type to status
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Property Status")]
        [Required(ErrorMessage = "Please provide the property status.")]
        public Library.Enums.PropertyViewingStatus PropertyStatus { get; set; }

        [UIHint("NumberInput")]
        [DisplayName("Property Price")]
        [Required(ErrorMessage = "Please provide the property price.")]
        public decimal PropertyPrice { get; set; }

        /// <summary>
        /// First line of the address for the property
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address 1")]
        [Required(ErrorMessage = "Please provide address line 1.")]
        [MaxLength(50, ErrorMessage = "The address line 1 must be less than 50 characters")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the address for the property
        /// </summary>
        [DisplayName("Address 2")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 2.")]
        [MaxLength(50, ErrorMessage = "The address line 2 must be less than 50 characters")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of the address for the property
        /// </summary>
        [DisplayName("Address 3")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 3.")]
        [MaxLength(50, ErrorMessage = "The address line 3 must be less than 50 characters")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Fourth line of the address for the property
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address 4")]
        [Required(ErrorMessage = "Please provide address line 4.")]
        [MaxLength(50, ErrorMessage = "The address line 4 must be less than 50 characters")]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Fifth line of the address for the property
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address 5")]
        [Required(ErrorMessage = "Please provide address line 5.")]
        [MaxLength(50, ErrorMessage = "The address line 5 must be less than 50 characters")]
        public string AddressLine5 { get; set; }

        /// <summary>
        /// Postcode of the address for the property
        /// </summary>
        [UIHint("PostcodeInput")]
        [DisplayName("Postcode")]
        [ValidPostcode(ErrorMessage = "Please provide a valid postcode")]
        [Required(ErrorMessage = "Please provide your postcode.")]
        [MaxLength(8, ErrorMessage = "The postcode must be less than 8 characters")]
        public string Postcode { get; set; }

        /// <summary>
        /// The number of bedrooms
        /// </summary>
        [UIHint("NumberInput")]
        [DisplayName("Number of Bedrooms")]
        [Required(ErrorMessage = "Please provide number of bedrooms.")]
        public int NumberOfBedrooms { get; set; }

        /// <summary>
        /// Details for the property
        /// </summary>
        [DisplayName("Details")]
        [UIHint("TextArea")]
        [Required(ErrorMessage = "Please provide Details.")]
        [MaxLength(1000, ErrorMessage = "The Details must be less than 1000 characters")]
        public string Details { get; set; }

        public int PropertyId { get; set; }

        public UpdatePropertyViewModel()
        {

        }

        public UpdatePropertyViewModel(int Id)
        {
            Property e = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            this.AddressLine1 = e.AddressLine1;
            this.AddressLine2 = e.AddressLine2;
            this.AddressLine3 = e.AddressLine3;
            this.AddressLine4 = e.AddressLine4;
            this.AddressLine5 = e.AddressLine5;
            this.Postcode = e.Postcode;
            string SaleTypeDesc = EstateAgentsRepository.GetPropertySaleTypeDescriptionById(e.PropertySaleTypeId);
            System.Enum.TryParse(SaleTypeDesc, out Library.Enums.PropertySaleType PropertySaleType);
            this.PropertySaleType = PropertySaleType;
            string TypeDesc = EstateAgentsRepository.GetPropertyTypeDescriptionByPropertyTypeId(e.PropertyTypeId); 
            System.Enum.TryParse(TypeDesc, out Library.Enums.PropertyType PropertyType);
            this.PropertyType = PropertyType;
            string status = EstateAgentsRepository.GetPropertyViewingStatusDescriptionById(e.PropertyStatusId);
            System.Enum.TryParse(status, out Library.Enums.PropertyViewingStatus PropertyStatus);
            this.PropertyStatus = PropertyStatus;
            this.PropertyPrice = e.PropertyPrice;
            this.NumberOfBedrooms = e.NumberOfBedrooms;
            this.Details = e.AdditionalDetails;
            this.PropertyId = Id;
        }
    }
}