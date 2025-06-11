using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using selenium_csharp_ui_automation_framework.driver.manager;

namespace selenium_csharp_ui_automation_framework.driver.factory
{
    public static class DriverFactory
    {

    public static IDriver CreateDriver(string browserName)
        {
            return browserName.ToLower() switch
            {
                "chrome" => new ChromeDriverManager(),
                "firefox" => new FirefoxDriverManager(),
                "edge" => new EdgeDriverManager(),
                _ => throw new ArgumentException($"Browser '{browserName}' is not supported.")
            };
        }
    }
}
