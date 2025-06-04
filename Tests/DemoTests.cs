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

            Console.WriteLine("Title : " + DriverManager.GetDriver().Title);
            Assert.That(DriverManager.GetDriver().Title.Contains(LoginPageConstants.Title), "Title does not contain " + LoginPageConstants.Title);

            LoginPage loginPage = new LoginPage();
            loginPage.verifyThatLoginButtonIsDisplayed();
            loginPage.login(config.Username, config.Password);

            HomePage homePage = new HomePage();
            homePage.VerifyThatTitleProductIsDisplayed();

            Thread.Sleep(5000);
        }
    }
}