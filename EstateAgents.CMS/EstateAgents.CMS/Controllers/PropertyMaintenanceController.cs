using EstateAgents.CMS.Models.PropertyMaintenance;
using EstateAgents.Library.DAL;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.CMS.Controllers
{
    [RoutePrefix("PropertyMaintenance")]
    public class PropertyMaintenanceController : Controller
    {
        public ActionResult PropertyMaintenance()
        {
            PropertyMaintenanceViewModel model = new PropertyMaintenanceViewModel();
            return View(model);
        }

        public ActionResult NewProperty()
        {
            NewPropertyViewModel model = new NewPropertyViewModel();
            return View(model);
        }

        [Route("UpdateProperty/{Id}")]
        public ActionResult UpdateProperty(int Id)
        {
            UpdatePropertyViewModel model = new UpdatePropertyViewModel(Id);
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdatePropertyRequest(UpdatePropertyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Property p = EstateAgentsRepository.GetPropertyByPropertyId(model.PropertyId);
                p.NumberOfBedrooms = model.NumberOfBedrooms;
                int SaleType = EstateAgentsRepository.GetPropertySaleTypeIdByDescription(model.PropertySaleType.ToString());
                p.PropertySaleTypeId = SaleType;
                int Type = EstateAgentsRepository.GetPropertyTypeIdByDescription(model.PropertyType.ToString());
                p.PropertyTypeId = Type;
                p.PropertyPrice = model.PropertyPrice;
                p.AddressLine1 = model.AddressLine1;
                p.AddressLine2 = model.AddressLine2;
                p.AddressLine3 = model.AddressLine3;
                p.AddressLine4 = model.AddressLine4;
                p.AddressLine5 = model.AddressLine5;
                p.Postcode = model.Postcode;
                p.NumberOfBedrooms = model.NumberOfBedrooms;
                p.AdditionalDetails = model.Details;
                int Status = EstateAgentsRepository.GetPropertyViewingStatusIdByDescription(model.PropertyStatus.ToString());
                p.PropertyStatusId = Status;

                EstateAgentsRepository.UpdateProperty(p);

                PropertyMaintenanceViewModel m = new PropertyMaintenanceViewModel();
                return View("PropertyMaintenance", m);
            }
            else
            {
                return RedirectToAction("PropertyMaintenance", "PropertyMaintenance");
            }
        }

        [Route("PropertyImages/{Id}")]
        public ActionResult PropertyImages(int Id)
        {
            PropertyImagesViewModel model = new PropertyImagesViewModel(Id);
            return View(model);
        }

        [Route("MarkPropertyAsClosed/{Id}")]
        public ActionResult MarkPropertyAsClosed(int Id)
        {
            Property p = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            p.ClosedDate = DateTime.Now;
            EstateAgentsRepository.UpdateProperty(p);

            PropertyMaintenanceViewModel model = new PropertyMaintenanceViewModel();
            return View("PropertyMaintenance", model);
        }

        [Route("RelistProperty/{Id}")]
        public ActionResult RelistProperty(int Id)
        {
            Property p = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            p.ClosedDate = null;
            EstateAgentsRepository.UpdateProperty(p);

            PropertyMaintenanceViewModel model = new PropertyMaintenanceViewModel();
            return View("PropertyMaintenance", model);
        }

        public ActionResult NewPropertyImage(PropertyImagesViewModel model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    MemoryStream target = new MemoryStream();
                    file.InputStream.CopyTo(target);
                    byte[] ImageData = target.ToArray();

                    EstateAgents.Library.DAL.PropertyImages p = new EstateAgents.Library.DAL.PropertyImages();
                    p.Created = DateTime.Now;
                    p.Description = model.ImageDescription;
                    p.ImageData = ImageData;
                    p.PropertyId = model.PropertyId;
                    EstateAgentsRepository.CreatePropertyImage(p);
                }

                PropertyMaintenanceViewModel m = new PropertyMaintenanceViewModel();
                return View("PropertyMaintenance", m);
            }

            return View("PropertyMaintenance");
        }

        [Route("MarkPropertyImageAsDeleted/{Id}")]
        public ActionResult MarkPropertyImageAsDeleted(int Id)
        {
            PropertyImages p = EstateAgentsRepository.GetPropertyImageById(Id);
            p.Deleted = DateTime.Now;
            EstateAgentsRepository.UpdatePropertyImages(p);

            PropertyMaintenanceViewModel model = new PropertyMaintenanceViewModel();
            return View("PropertyMaintenance", model);
        }

        [HttpPost]
        public ActionResult NewPropertyRequest(NewPropertyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Property p = new Property();
                p.NumberOfBedrooms = model.NumberOfBedrooms;
                int SaleType = EstateAgentsRepository.GetPropertySaleTypeIdByDescription(model.PropertySaleType.ToString());
                p.PropertySaleTypeId = SaleType;
                int Type = EstateAgentsRepository.GetPropertyTypeIdByDescription(model.PropertyType.ToString());
                p.PropertyTypeId = Type;
                p.PropertyPrice = model.PropertyPrice;
                p.AddressLine1 = model.AddressLine1;
                p.AddressLine2 = model.AddressLine2;
                p.AddressLine3 = model.AddressLine3;
                p.AddressLine4 = model.AddressLine4;
                p.AddressLine5 = model.AddressLine5;
                p.Postcode = model.Postcode;
                p.NumberOfBedrooms = model.NumberOfBedrooms;
                p.AdditionalDetails = model.Details;
                p.PropertyStatusId = 1;
                p.PostedDate = DateTime.Now;
                p.VendorClientId = 0;
                
                EstateAgentsRepository.CreateProperty(p);

                PropertyMaintenanceViewModel m = new PropertyMaintenanceViewModel();
                return View("PropertyMaintenance", m);
            }
            else
            {
                return RedirectToAction("PropertyMaintenance", "PropertyMaintenance");
            }
        }

        [Route("PropertyFeatures/{Id}")]
        public ActionResult PropertyFeatures(int Id)
        {
            PropertyFeaturesViewModel model = new PropertyFeaturesViewModel(Id);
            return View(model);
        }

        [Route("MarkPropertyFeatureAsDeleted/{Id}")]
        public ActionResult MarkPropertyFeatureAsDeleted(int Id)
        {
            PropertyFeatures p = EstateAgentsRepository.GetPropertyFeaturesById(Id);
            p.Deleted = DateTime.Now;
            EstateAgentsRepository.UpdatePropertyFeatures(p);

            PropertyMaintenanceViewModel model = new PropertyMaintenanceViewModel();
            return View("PropertyMaintenance", model);
        }

        [Route("NewPropertyFeature/{Id}")]
        public ActionResult NewPropertyFeature(int Id)
        {
            NewPropertyFeatureViewModel model = new NewPropertyFeatureViewModel(Id);
            return View(model);
        }

        [HttpPost]
        public ActionResult NewPropertyFeatureRequest(NewPropertyFeatureViewModel model)
        {
            if (ModelState.IsValid)
            {
                PropertyFeatures p = new PropertyFeatures();
                p.Created = DateTime.Now;
                p.Description = model.Description;
                p.PropertyId = model.PropertyId;
                EstateAgentsRepository.CreatePropertyFeatures(p);

                PropertyMaintenanceViewModel m = new PropertyMaintenanceViewModel();
                return View("PropertyMaintenance", m);
            }
            else
            {
                return RedirectToAction("PropertyMaintenance", "PropertyMaintenance");
            }
        }
    }
}