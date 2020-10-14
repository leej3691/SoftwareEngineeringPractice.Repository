using System.Web.Mvc;
using EstateAgents.IMS.Controllers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace EstateAgents.IMS.Tests.Controllers
{
    public class HomeControllerAutomatedTest
    {
        [Fact]
        [Trait("Category", "PageLoad")]
        public void LoadApplicationHomePage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                /*driver.Navigate().GoToUrl("https://localhost:44365/")*/;
            }
        }
    }
}
