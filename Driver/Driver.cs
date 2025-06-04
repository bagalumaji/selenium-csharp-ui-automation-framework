using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_csharp_ui_automation_framework.driver
{

    public sealed class Driver
    {
        private Driver() { }
        public static void InitDriver()
        {
            if (DriverManager.GetDriver() == null)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
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
