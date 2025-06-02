using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_csharp_ui_automation_framework.DriverInfo
{
    public class Driver
    {
        public static void InitDriver()
        {
            if (DriverManger.GetDriver() == null)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                DriverManger.SetDriver(driver);
            }

        }

        public static void QuitDriver()
        {
            if (DriverManger.GetDriver() != null)
            {
                try
                {
                    DriverManger.GetDriver().Quit();
                }
                finally
                {
                    DriverManger.UnloadDriver();
                }
            }
        }
    }
}
