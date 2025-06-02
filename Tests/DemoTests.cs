using selenium_csharp_ui_automation_framework.DriverInfo;
using selenium_csharp_ui_automation_framework.Tests.TestSetup;

namespace selenium_csharp_ui_automation_framework.Tests
{
    public class DemoTests : BaseTestSetup
    {

        [Test]
        public void DemoTest()
        {
            String title = "Swag Labs";
            DriverManager.GetDriver().Navigate().GoToUrl("https://www.saucedemo.com/");
            Console.WriteLine("Title : " + DriverManager.GetDriver().Title);
            Assert.That(DriverManager.GetDriver().Title.Contains(title), "Title does not contain "+title);
        }
    }
}