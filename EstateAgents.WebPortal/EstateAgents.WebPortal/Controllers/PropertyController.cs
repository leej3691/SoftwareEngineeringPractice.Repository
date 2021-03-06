﻿using EstateAgents.Library.DAL;
using EstateAgents.WebPortal.Models.Properties;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    [RoutePrefix("Property")]
    public class PropertyController : Controller
    {
        // GET: Property
        public ActionResult PropertyShowroom()
        {
            PropertyShowRoomViewModel model = new PropertyShowRoomViewModel();
            return View(model);
        }

        public ActionResult PropertySearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PropertySearchRequest(PropertySearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                List<Property> pList = EstateAgentsRepository.GetPropertyListBySearchCriteria(model.IncludeSoldProperties.ToString(), model.Location, model.NumberOfBedrooms, model.PriceFrom, model.PriceTo, model.PropertySaleType.ToString(), model.PropertyType.ToString());

                PropertyShowRoomViewModel vm = new PropertyShowRoomViewModel(pList);

                return View("PropertyShowroom", vm);
            }
            else
            {
                return View("PropertySearch", model);
            }

        }

        public ActionResult PropertySaved()
        {
            PropertySavedViewModel model = new PropertySavedViewModel();
            return View(model);
        }

        public ActionResult PropertyDetails()
        {
            return View();
        }

        [Route("PropertyDetails/{id}")]
        public ActionResult PropertyDetails(int Id)
        {
            //var webClient = new WebClient();

            //byte[] imageBytes = webClient.DownloadData("https://pbprodimages.azureedge.net/images/large/c292d1fb-2b4b-4004-9a88-fa6ff0c3d0c0.JPG");
            //PropertyImages i = new PropertyImages();
            //i.PropertyId = Id;
            //i.Description = "Front of House";
            //i.ImageData = imageBytes;
            //EstateAgentsRepository.CreatePropertyImage(i);

            //byte[] imageBytes2 = webClient.DownloadData("https://pbprodimages.azureedge.net/images/large/5f3272dc-af5a-4b3d-8353-12b1ffaae839.JPG");
            //PropertyImages i2 = new PropertyImages();
            //i2.PropertyId = Id;
            //i2.Description = "Living Room";
            //i2.ImageData = imageBytes2;
            //EstateAgentsRepository.CreatePropertyImage(i2);

            //byte[] imageBytes3 = webClient.DownloadData("https://pbprodimages.azureedge.net/images/large/d9a82948-9a75-4d77-9b37-b248a20d44a5.JPG");
            //PropertyImages i3 = new PropertyImages();
            //i3.PropertyId = Id;
            //i3.Description = "Kitchen / Dining Area";
            //i3.ImageData = imageBytes3;
            //EstateAgentsRepository.CreatePropertyImage(i3);

            //byte[] imageBytes4 = webClient.DownloadData("https://pbprodimages.azureedge.net/images/large/d2b459f6-362f-4979-9e10-9ded6df4ff60.JPG");
            //PropertyImages i4 = new PropertyImages();
            //i4.PropertyId = Id;
            //i4.Description = "Master Bedroom";
            //i4.ImageData = imageBytes4;
            //EstateAgentsRepository.CreatePropertyImage(i4);

            //byte[] imageBytes5 = webClient.DownloadData("https://pbprodimages.azureedge.net/images/large/8d40a644-3586-4f37-b4b3-59563dec9c64.JPG");
            //PropertyImages i5 = new PropertyImages();
            //i5.PropertyId = Id;
            //i5.Description = "Bathroom";
            //i5.ImageData = imageBytes5;
            //EstateAgentsRepository.CreatePropertyImage(i5);

            //byte[] imageBytes6 = webClient.DownloadData("https://pbprodimages.azureedge.net/images/large/e27747e3-8de7-4921-bf8f-caea7a5ba91e.JPG");
            //PropertyImages i6 = new PropertyImages();
            //i6.PropertyId = Id;
            //i6.Description = "Spare Bedroom";
            //i6.ImageData = imageBytes6;
            //EstateAgentsRepository.CreatePropertyImage(i6);

            PropertyDetailsViewModel model = new PropertyDetailsViewModel(Id);

            return View(model);
        }

        [Route("TogglePropertySaved/{id}/{ClientId}/{PropertySaved}/{View}")]
        public ActionResult TogglePropertySaved(int Id, int ClientId, bool PropertySaved, string view)
        {
            PropertySaved p = EstateAgentsRepository.GetPropertySavedByClientIdAndPropertyId(ClientId, Id);
            if(p == null)
            {
                PropertySaved PropertySavedNew = new PropertySaved();
                PropertySavedNew.PropertyId = Id;
                PropertySavedNew.ClientId = ClientId;
                PropertySavedNew.Saved = PropertySaved;
                EstateAgentsRepository.CreatePropertySaved(PropertySavedNew);
            }
            else
            {
                p.Saved = PropertySaved;
                EstateAgentsRepository.UpdatePropertySaved(p);
            }

            if(view == "PropertyDetails")
            {
                PropertyDetailsViewModel model = new PropertyDetailsViewModel(Id);
                return View("PropertyDetails", model);
            }
            else if (view == "PropertySaved")
            {
                PropertySavedViewModel model = new PropertySavedViewModel();
                return View("PropertySaved", model);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [Route("PropertyBookViewing/{PropertyId}")]
        public ActionResult PropertyBookViewing(int PropertyId)
        {
            PropertyBookViewingViewModel model = new PropertyBookViewingViewModel(PropertyId);
            return View(model);
        }

        [HttpPost]
        public ActionResult PropertyBookViewingRequest(PropertyBookViewingViewModel model)
        {
            if (ModelState.IsValid)
            {
                PropertyViewings p = new PropertyViewings();
                p.ViewingDate = model.ViewingDate;
                p.ViewingTime = model.ViewingTime;
                p.ClientId = model.ClientId;
                p.PropertyId = model.PropertyDetails.Id;
                p.PropertyViewingStatusId = 1;
                EstateAgentsRepository.CreatePropertyViewing(p);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("PropertyBookViewing", model);
            }
              
        }

        [Route("PropertyMakeOffer/{PropertyId}")]
        public ActionResult PropertyMakeOffer(int PropertyId)
        {
            PropertyMakeOfferViewModel model = new PropertyMakeOfferViewModel(PropertyId);
            return View(model);
        }

        public ActionResult PropertyMakeOfferRequest(PropertyMakeOfferViewModel model)
        {
            if (ModelState.IsValid)
            {
                PropertyOffers p = new PropertyOffers();
                p.ClientId = model.ClientId;
                p.OfferAmount = model.PropertyOffer.OfferAmount;
                p.PropertyOfferStatusId = 1;
                p.PropertyId = model.PropertyDetails.Id;
                EstateAgentsRepository.CreatePropertyOffer(p);

                PropertyOffersViewModel m = new PropertyOffersViewModel();
                return View("PropertyOffers", m);
            }
            else
            {
                return View("PropertyMakeOffer", model);
            }
        }

        [Route("PropertyOfferWithdraw/{Id}")]
        public ActionResult PropertyOfferWithdraw(int Id)
        {
            PropertyOffers p = EstateAgentsRepository.GetPropertyOffersById(Id);
            p.PropertyOfferStatusId = 4;
            EstateAgentsRepository.UpdatePropertyOffer(p);
            PropertyOffersViewModel m = new PropertyOffersViewModel();
            return View("PropertyOffers", m);
        }

        public ActionResult PropertyViewings()
        {
            PropertyViewingsViewModel model = new PropertyViewingsViewModel();
            return View(model);
        }

        [Route("CancelPropertyViewing/{Id}")]
        public ActionResult CancelPropertyViewing(int Id)
        {
            PropertyViewings p = EstateAgentsRepository.GetPropertyViewingById(Id);
            p.Cancelled = DateTime.Now;
            EstateAgentsRepository.UpdatePropertyViewing(p);

            PropertyViewingsViewModel model = new PropertyViewingsViewModel();
            return View("PropertyViewings", model);
        }

        public ActionResult PropertyOffers()
        {
            PropertyOffersViewModel model = new PropertyOffersViewModel();
            return View(model);
        }
    }
}