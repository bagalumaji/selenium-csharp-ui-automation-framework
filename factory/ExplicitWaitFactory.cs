using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.driver;
using selenium_csharp_ui_automation_framework.exceptions;
using SeleniumExtras.WaitHelpers;
namespace selenium_csharp_ui_automation_framework.factory
{
    public class ExplicitWaitFactory
    {
        private static WebDriverWait GetExplicitWait(int timeoutInSeconds)
        {

            var driver = DriverManager.GetDriver();
            return driver == null
                ? throw new DriverNotCreatedException("WebDriver instance is null. Ensure that the driver is initialized before calling ExplicitWaitFactory.")
                : new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        }

        public static IWebElement WaitForVisibilityOfElement(By by, int? timeoutInSeconds = null)
        {
            return GetExplicitWait(timeoutInSeconds ?? ConfigReader.GetConfig().Timeout.MinimumTimeout)
                .Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
