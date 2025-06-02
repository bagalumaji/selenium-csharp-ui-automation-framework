using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_csharp_ui_automation_framework.DriverInfo
{
    public class Driver
    {
        public static void InitDriver()
        {
            if (DriverManager.GetDriver() == null)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
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
