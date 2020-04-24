using EstateAgents.IMS.Models.EmployeeManagement;
using EstateAgents.Library.DAL;
using EstateAgents.Library.Enums;
using System;
using System.Web.Mvc;

namespace EstateAgents.IMS.Controllers
{
    [RoutePrefix("EmployeeManagement")]
    public class EmployeeManagementController : Controller
    {
        public ActionResult ManageEmployees()
        {
            ManageEmployeesViewModel model = new ManageEmployeesViewModel();
            return View(model);
        }

        [Route("UpdateEmployee/{Id}")]
        public ActionResult UpdateEmployee(int Id)
        {
            UpdateEmployeeViewModel model = new UpdateEmployeeViewModel(Id);
            return View("UpdateEmployee", model);
        }

        [HttpPost]
        public ActionResult UpdateEmployeeRequest(UpdateEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee e = EstateAgentsRepository.GetEmployeeById(model.EmployeeId);
                e.AddressLine1 = model.AddressLine1;
                e.AddressLine2 = model.AddressLine2;
                e.AddressLine3 = model.AddressLine3;
                e.AddressLine4 = model.AddressLine4;
                e.AddressLine5 = model.AddressLine5;
                e.Created = model.DateOfStart;
                e.DateLeft = model.DateLeft;
                e.DateOfBirth = model.DateOfBirth;
                e.DateStart = model.DateOfStart;
                e.Email = model.Email;
                e.Forename = model.Forename;
                e.Mobile = model.Mobile;
                e.Postcode = model.Postcode;
                e.Surname = model.Surname;
                e.Title = model.Title.Value.ToString();
                EstateAgentsRepository.UpdateEmployee(e);

                return RedirectToAction("ManageEmployees", "EmployeeManagement");
            }
            else
            {
                return RedirectToAction("ManageEmployees", "EmployeeManagement");
            }
        }

        public ActionResult NewEmployee()
        {
            NewEmployeeViewModel model = new NewEmployeeViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult NewEmployeeRequest(NewEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee e = new Employee();
                e.AddressLine1 = model.AddressLine1;
                e.AddressLine2 = model.AddressLine2;
                e.AddressLine3 = model.AddressLine3;
                e.AddressLine4 = model.AddressLine4;
                e.AddressLine5 = model.AddressLine5;
                e.Created = model.DateOfStart;
                e.DateLeft = model.DateLeft;
                e.DateOfBirth = model.DateOfBirth;
                e.DateStart = model.DateOfStart;
                e.Email = model.Email;
                e.Forename = model.Forename;
                e.Mobile = model.Mobile;
                e.Postcode = model.Postcode;
                e.Surname = model.Surname;
                e.Title = model.Title.Value.ToString();
                EstateAgentsRepository.CreateEmployee(e);

                return RedirectToAction("ManageEmployees", "EmployeeManagement");
            }
            else
            {
                return RedirectToAction("ManageEmployees", "EmployeeManagement");
            }
        }
    }
}