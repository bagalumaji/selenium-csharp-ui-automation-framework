using selenium_csharp_ui_automation_framework.DriverInfo;
using selenium_csharp_ui_automation_framework.Tests.TestSetup;

namespace selenium_csharp_ui_automation_framework.Tests
{
    public class DemoTests : BaseTestSetup
    {

        [Test]
        public void DemoTest()
        {
            DriverManger.GetDriver().Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Title : " + DriverManger.GetDriver().Title);
            Assert.That(DriverManger.GetDriver().Title.Contains("Google"), "Title does not contain 'Google'");
        }
    }
}