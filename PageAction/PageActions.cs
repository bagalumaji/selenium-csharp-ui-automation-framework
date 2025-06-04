using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.driver;

namespace selenium_csharp_ui_automation_framework.PageAction
{
    public sealed class PageActions
    {
        private PageActions() { }
        public static void NavigateToUrl(string url)
        {
            DriverManager.GetDriver().Navigate().GoToUrl(url);
        }
        public static void Click(IWebElement element)
        {
            element.Click();
        }
        public static void SendKeys(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static string GetTitle()
        {
            return DriverManager.GetDriver().Title;
        }

        public static bool IsElementDisplayed(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
