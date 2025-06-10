using selenium_csharp_ui_automation_framework.driver;
using selenium_csharp_ui_automation_framework.Pages;
using selenium_csharp_ui_automation_framework.Tests.TestSetup;
using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.constants;
namespace selenium_csharp_ui_automation_framework.Tests
{
    public class DemoTests : BaseTestSetup
    {
        [Test]
        public void DemoTest()
        {
            var config = ConfigReader.GetConfig();

            Console.WriteLine("Title : " + PageAction.PageActions.Title);
            Assert.That(PageAction.PageActions.Title.Contains(LoginPageConstants.Title), "Title does not contain " + LoginPageConstants.Title);

            LoginPage loginPage = new();
            loginPage.verifyThatLoginButtonIsDisplayed();
            loginPage.login(config.Username, config.Password);

            HomePage homePage = new();
            homePage.VerifyThatTitleProductIsDisplayed();
        }
    }
}