using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.driver;
using SeleniumExtras.WaitHelpers;
namespace selenium_csharp_ui_automation_framework.factory
{
    public class ExplicitWaitFactory
    {
        private static WebDriverWait getExplicitWait(int timeoutInSeconds)
        {
            return new WebDriverWait(DriverManager.GetDriver(), TimeSpan.FromSeconds(timeoutInSeconds));
        }

        public static IWebElement WaitForVisibilityOfElement(By by, int? timeoutInSeconds = null)
        {
            return getExplicitWait(timeoutInSeconds ?? ConfigReader.GetConfig().Timeout.DefaultTimeout)
                .Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
