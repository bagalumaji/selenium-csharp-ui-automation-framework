using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_csharp_ui_automation_framework.Tests.TestSetup;

namespace selenium_csharp_ui_automation_framework.Tests
{
    public class DemoTests :BaseTestSetup
    {
       
        [Test]
        public void DemoTest()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
        }
    }
}