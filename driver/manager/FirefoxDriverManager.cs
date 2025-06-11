using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace selenium_csharp_ui_automation_framework.driver.manager
{
    public class FirefoxDriverManager : IDriver
    {
        public IWebDriver GetDriver()
        {
            return new FirefoxDriver();
        }
    }
}
