using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.DriverInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_csharp_ui_automation_framework.PageAction
{
    public class PageActions
    {
        public static void NavigateToUrl(string url)
        {
           DriverManager.GetDriver().Navigate().GoToUrl(url);
        }
        public static void click(IWebElement element)
        {
           element.Click();
        }
        public static void sendKeys(IWebElement element, string text)
        {
            element.Clear();
           element.SendKeys(text);
        }

        public static string getTitle()
        {
            return DriverManager.GetDriver().Title;
        }

    }
}
