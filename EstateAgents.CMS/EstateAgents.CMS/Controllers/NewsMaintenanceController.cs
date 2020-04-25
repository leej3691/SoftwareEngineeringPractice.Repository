using EstateAgents.CMS.Models.NewsMaintenance;
using EstateAgents.Library.DAL;
using System;
using System.Web.Mvc;

namespace EstateAgents.CMS.Controllers
{
    [RoutePrefix("NewsMaintenance")]
    public class NewsMaintenanceController : Controller
    {
        public ActionResult NewsMaintenance()
        {
            NewsMaintenanceViewModel model = new NewsMaintenanceViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddNewsRequest(NewsMaintenanceViewModel model)
        {
            if (ModelState.IsValid)
            {
                News n = new News();
                n.Description = model.NewsDescription;
                EstateAgentsRepository.CreateNews(n);

                return RedirectToAction("NewsMaintenance", "NewsMaintenance");
            }
            else
            {
                return RedirectToAction("NewsMaintenance", "NewsMaintenance");
            }
        }

        [Route("MarkNewsAsDeleted/{Id}")]
        public ActionResult MarkNewsAsDeleted(int Id)
        {
            News n = EstateAgentsRepository.GetNewsByNewsId(Id);
            n.Deleted = DateTime.Now;
            EstateAgentsRepository.UpdateNews(n);

            NewsMaintenanceViewModel model = new NewsMaintenanceViewModel();
            return View("NewsMaintenance", model);
        }
    }
}