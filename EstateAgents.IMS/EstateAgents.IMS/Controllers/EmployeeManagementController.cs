using EstateAgents.IMS.Models.EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.IMS.Controllers
{
    public class EmployeeManagementController : Controller
    {
        public ActionResult ManageEmployees()
        {
            ManageEmployeesViewModel model = new ManageEmployeesViewModel();
            return View(model);
        }
    }
}