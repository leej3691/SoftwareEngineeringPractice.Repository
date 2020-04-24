using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstateAgents.IMS;
using EstateAgents.IMS.Controllers;
using EstateAgents.IMS.Models.Home;

namespace EstateAgents.IMS.Tests.Controllers
{
    [TestClass]
    public class EmployeeManagementControllerTest
    {
        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Employees return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageEmployeesView()
        {
            // Arrange - Initialise variables
            var controller = new EmployeeManagementController();

            // Act - Invoke method to test
            var result = controller.ManageEmployees() as ViewResult;
   
            // Assert - Verify the act
            Assert.IsNotNull(result);
        }
    }
}
