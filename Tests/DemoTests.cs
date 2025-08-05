using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.constants;
using selenium_csharp_ui_automation_framework.Pages;
using selenium_csharp_ui_automation_framework.reports;
using selenium_csharp_ui_automation_framework.Tests.TestSetup;
namespace selenium_csharp_ui_automation_framework.Tests
{
    public class DemoTests : BaseTestSetup
    {
       
        [Test]
        public void DemoTest()
        {
            var config = ConfigReader.GetConfig();

            Assert.That(PageAction.PageActions.Title, Does.Contain(LoginPageConstants.Title), "Title does not contain " + LoginPageConstants.Title);
          
            LoginPage loginPage = new();
            loginPage.VerifyThatLoginButtonIsDisplayed();
            loginPage.LoginToApplication(config.Username, config.Password);
            ExtentLogger.Info("Title : " + PageAction.PageActions.Title);

            ProductsPage homePage = new();
            homePage.VerifyThatTitleProductIsDisplayed();
        }
    }
}