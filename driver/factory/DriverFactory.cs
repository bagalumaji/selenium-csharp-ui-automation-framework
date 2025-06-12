using selenium_csharp_ui_automation_framework.driver.manager;
using selenium_csharp_ui_automation_framework.enums;
using selenium_csharp_ui_automation_framework.exceptions;

namespace selenium_csharp_ui_automation_framework.driver.factory
{
    public static class DriverFactory
    {
        private static readonly Dictionary<BrowserTypes, IDriver> _drivers = new()
        {
            { BrowserTypes.CHROME,new ChromeDriverManager()},
            { BrowserTypes.FIREFOX, new FirefoxDriverManager() },
            { BrowserTypes.EDGE, new EdgeDriverManager() }
        };


        public static IDriver CreateDriver(BrowserTypes browserType)
        {
            return _drivers.TryGetValue(browserType, out var driver)
                ? driver : throw new BrowserTypeNotSupportedException($"Browser type '{browserType.ToString()}' is not supported....");
        }
    }
}
