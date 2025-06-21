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
            ExtentReport.InitReport();
            var config = ConfigReader.GetConfig();

            Console.WriteLine("Title : " + PageAction.PageActions.Title);
            ExtentReport.CreateTest("Demo Test123");
            ExtentLogger.Info("Title : " + PageAction.PageActions.Title);

            Assert.That(PageAction.PageActions.Title.Contains(LoginPageConstants.Title), "Title does not contain " + LoginPageConstants.Title);
            ExtentLogger.Info("Title : " + PageAction.PageActions.Title);

            LoginPage loginPage = new();
            loginPage.verifyThatLoginButtonIsDisplayed();
            loginPage.login(config.Username, config.Password);
            ExtentLogger.Info("Title : " + PageAction.PageActions.Title);

            ProductsPage homePage = new();
            homePage.VerifyThatTitleProductIsDisplayed();
            ExtentLogger.Pass("Demo test passed successfully.");
            ExtentReport.FlushReport();
        }
    }
}