using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace selenium_csharp_ui_automation_framework.driver.manager
{
    public class EdgeDriverManager : IDriver
    {
        public IWebDriver GetDriver()
        {
            return new EdgeDriver();
        }
    }
}
