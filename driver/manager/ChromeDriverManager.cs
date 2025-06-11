using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_csharp_ui_automation_framework.driver.manager
{
    public class ChromeDriverManager : IDriver
    {
        public IWebDriver GetDriver()
        {
            return new ChromeDriver();
        }
    }
}
