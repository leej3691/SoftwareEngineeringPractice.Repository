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
    public class CustomerManagementControllerTest
    {
        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Customers return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageCustomersView()
        {
            // Arrange - Initialise variables
            var controller = new CustomerManagementController();

            // Act - Invoke method to test
            var result = controller.ManageCustomers() as ViewResult;
   
            // Assert - Verify the act
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Messages return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageMessagesView()
        {
            // Arrange - Initialise variables
            var controller = new CustomerManagementController();

            // Act - Invoke method to test
            var result = controller.ManageMessages() as ViewResult;

            // Assert - Verify the act
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("DataAccess")]
        [Description("View Test - Customer details by id return view test")]
        [Priority(1)]
        [Owner("Lee Jones")]
        public void TestViewingCustomerDetailsById()
        {
            // Arrange - Initialise variables
            var controller = new CustomerManagementController();

            // Act - Invoke method to test
            var result = controller.CustomerDetails(1) as ViewResult;

            // Assert - Verify the act
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("DataAccess")]
        [Description("View Test - Customer message by id return view test")]
        [Priority(1)]
        [Owner("Lee Jones")]
        public void TestViewingCustomerMessagesById()
        {
            // Arrange - Initialise variables
            var controller = new CustomerManagementController();

            // Act - Invoke method to test
            var result = controller.CustomerMessages(1) as ViewResult;

            // Assert - Verify the act
            Assert.IsNotNull(result);
        }
    }
}
