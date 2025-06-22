using OpenQA.Selenium;

namespace selenium_csharp_ui_automation_framework.driver
{
    public sealed class DriverManager
    {
        private DriverManager() { }

        private static ThreadLocal<IWebDriver>? threadLocalDriver = new();

        public static IWebDriver? GetDriver() => threadLocalDriver?.Value;

        public static void SetDriver(IWebDriver driver)
        {
            threadLocalDriver ??= new ThreadLocal<IWebDriver>();
            threadLocalDriver.Value = driver;
        }

        public static void UnloadDriver()
        {
            if (threadLocalDriver?.IsValueCreated == true)
            {
                threadLocalDriver.Value?.Dispose();
                threadLocalDriver.Dispose();
                threadLocalDriver = null;
            }
        }
    }

}
