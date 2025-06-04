using OpenQA.Selenium;

namespace selenium_csharp_ui_automation_framework.driver
{
    public sealed class DriverManager
    {
        private DriverManager() { }
        private static ThreadLocal<IWebDriver> threadLocalDriver = new ThreadLocal<IWebDriver>();
        public static IWebDriver GetDriver() => threadLocalDriver.Value;

        public static void SetDriver(IWebDriver driver) => threadLocalDriver.Value = driver;
        public static void UnloadDriver()
        {
            if (threadLocalDriver.IsValueCreated && threadLocalDriver.Value != null)
            {
                threadLocalDriver.Value.Dispose();
                threadLocalDriver = null;
            }
        }
    }
}
