using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Web;

namespace EstateAgents.IMS.Models.Home
{
    public class HomeViewModel
    {
        public Employee EmployeeDetails { get; set; }
        public string UserRole { get; set; }

        public HomeViewModel()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Guid UserId = Guid.Parse(HttpContext.Current.User.Identity.GetUserId());
                this.EmployeeDetails = EstateAgentsRepository.GetEmployeeByUserId(UserId);

                string username = HttpContext.Current.User.Identity.GetUserName();
                this.UserRole = EstateAgentsRepository.GetUserRole(username);
            }
            else
            {
                this.EmployeeDetails = new Employee();
                this.UserRole = "";
            }
        }
    }
}