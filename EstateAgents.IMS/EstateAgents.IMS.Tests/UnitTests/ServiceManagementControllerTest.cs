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
    public class ServiceManagementControllerTest
    {
        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Brokers return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageBrokersView()
        {
            // Arrange - Initialise variables
            var controller = new ServiceManagementController();

            // Act - Invoke method to test
            var result = controller.ManageBrokers() as ViewResult;
   
            // Assert - Verify the act
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Removals return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageRemovalsView()
        {
            // Arrange - Initialise variables
            var controller = new ServiceManagementController();

            // Act - Invoke method to test
            var result = controller.ManageRemovals() as ViewResult;

            // Assert - Verify the act
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Valuations return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageValuationsView()
        {
            // Arrange - Initialise variables
            var controller = new ServiceManagementController();

            // Act - Invoke method to test
            var result = controller.ManageValuations() as ViewResult;

            // Assert - Verify the act
            Assert.IsNotNull(result);
        }
    }
}
