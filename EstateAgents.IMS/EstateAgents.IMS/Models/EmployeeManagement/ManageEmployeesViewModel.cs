using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.IMS.Models.EmployeeManagement
{
    public class ManageEmployeesViewModel
    {
        public List<Employee> Employees { get; set; }

        public ManageEmployeesViewModel()
        {
            this.Employees = EstateAgentsRepository.GetEmployeeList();
        }
    }
}