using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.driver;

namespace selenium_csharp_ui_automation_framework.utils
{
    public static class ScreenshotUtil
    {
        public static string TakeScreenshotAsString()
        {
            var driver = DriverManager.GetDriver() ?? throw new InvalidOperationException("Driver is not initialized.");
            if (driver is ITakesScreenshot screenshotDriver)
            {
                return screenshotDriver.GetScreenshot().AsBase64EncodedString;
            }
            else
            {
                throw new InvalidOperationException("Driver does not support screenshots.");
            }
        }
    }
}
