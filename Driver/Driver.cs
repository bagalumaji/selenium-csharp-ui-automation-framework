using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.driver.factory;

namespace selenium_csharp_ui_automation_framework.driver
{

    public sealed class Driver
    {
        private Driver() { }
        public static void InitDriver()
        {
            if (DriverManager.GetDriver() == null)
            {
                var config = ConfigReader.GetConfig();
                IWebDriver driver = DriverFactory.CreateDriver(config.Browser).GetDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(config.Timeout.PageLoadTimeout);
                driver.Navigate().GoToUrl(config.Url);
                DriverManager.SetDriver(driver);
            }
        }

        public static void QuitDriver()
        {
            if (DriverManager.GetDriver() != null)
            {
                try
                {
                    DriverManager.GetDriver().Quit();
                }
                finally
                {
                    DriverManager.UnloadDriver();
                }
            }
        }
    }
}
