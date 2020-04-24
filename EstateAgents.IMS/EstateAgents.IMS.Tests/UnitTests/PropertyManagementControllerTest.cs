using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstateAgents.IMS.Controllers;
using System.Web.Mvc;

namespace EstateAgents.IMS.Tests.Controllers
{
    [TestClass]
    public class PropertyManagementControllerTest
    {
        //From 
        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Viewings return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageViewingsView()
        {
            // Arrange - Initialise variables
            var controller = new PropertyManagementController();

            // Act - Invoke method to test
            var result = controller.ManageViewings() as ViewResult;
   
            // Assert - Verify the act
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("Views")]
        [Description("View Test - Manage Offers return view test")]
        [Priority(0)]
        [Owner("Lee Jones")]
        public void TestManageOffersView()
        {
            // Arrange - Initialise variables
            var controller = new PropertyManagementController();

            // Act - Invoke method to test
            var result = controller.ManageOffers() as ViewResult;

            // Assert - Verify the act
            Assert.IsNotNull(result);
        }


    }
}
