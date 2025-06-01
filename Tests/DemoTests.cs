using selenium_csharp_ui_automation_framework.Tests.TestSetup;

namespace selenium_csharp_ui_automation_framework.Tests
{
    public class DemoTests : BaseTestSetup
    {
       
        [Test]
        public void DemoTest()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Title : "+_driver.Title);
            Assert.That(_driver.Title.Contains("Google"), "Title does not contain 'Google'");
        }
    }
}