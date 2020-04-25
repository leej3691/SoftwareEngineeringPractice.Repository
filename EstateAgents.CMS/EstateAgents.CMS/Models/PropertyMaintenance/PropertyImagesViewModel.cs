using EstateAgents.Library.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.CMS.Models.PropertyMaintenance
{
    public class PropertyImagesViewModel
    {
        public string PropertyAddress { get; set; }
        public List<PropertyImages> PropertyImages { get; set; }
        public int PropertyId { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Image Description")]
        [Required(ErrorMessage = "Please provide the image description.")]
        [MaxLength(50, ErrorMessage = "The image description must be less than 50 characters")]
        public string ImageDescription { get; set; }

        public PropertyImagesViewModel()
        {
            
        }

        public PropertyImagesViewModel(int PropertyId)
        {
            Property p = EstateAgentsRepository.GetPropertyByPropertyId(PropertyId);
            this.PropertyAddress = p.AddressLine1 + "," + p.AddressLine2 + "," + p.AddressLine3 + "," + p.AddressLine4 + "," + p.AddressLine5 + "," + p.Postcode;
            this.PropertyImages = EstateAgentsRepository.GetPropertyImagesByPropertyId(PropertyId);
            this.PropertyId = PropertyId;
        }
    }
}