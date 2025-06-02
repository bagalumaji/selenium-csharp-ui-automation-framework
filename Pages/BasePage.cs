using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selenium_csharp_ui_automation_framework.DriverInfo;
namespace selenium_csharp_ui_automation_framework.Pages
{
    abstract internal class BasePage
    {
        protected IWebDriver driver;
        protected BasePage() {
           this.driver = DriverManager.GetDriver();
        }
    }
}
