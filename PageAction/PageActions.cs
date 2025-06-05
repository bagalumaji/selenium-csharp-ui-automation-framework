using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.driver;

namespace selenium_csharp_ui_automation_framework.PageAction
{
    public static class PageActions
    {
        public static void NavigateToUrl(string url)
        {
            DriverManager.GetDriver().Navigate().GoToUrl(url);
        }
        public static void ClickOnElement(this IWebElement element)
        {
            element.Click();
        }
        public static void SendKeysToElement(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static string Title => DriverManager.GetDriver().Title;
        

        public static bool IsElementDisplayed(this IWebElement element)
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
