using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.driver;
using selenium_csharp_ui_automation_framework.factory;

namespace selenium_csharp_ui_automation_framework.PageAction
{
    public static class PageActions
    {
        public static void NavigateToUrl(string url)
        {
            DriverManager.GetDriver().Navigate().GoToUrl(url);
        }
        public static void ClickOnElement(this By locator, int? timeoutInSeconds)
        {
            ExplicitWaitFactory
                .WaitForVisibilityOfElement(locator, timeoutInSeconds)
                .Click();
        }
        public static void ClickOnElement(this By locator)
        {
            ClickOnElement(locator, null);
        }

        public static void SendKeysToElement(this By locator, string text, int? timeoutInSeconds)
        {
            ExplicitWaitFactory
                .WaitForVisibilityOfElement(locator, timeoutInSeconds)
                .SendKeys(text);
        }
        public static void SendKeysToElement(this By locator, string text)
        {
            SendKeysToElement(locator, text, null);
        }

        public static string Title => DriverManager.GetDriver().Title;

        public static bool IsElementDisplayed(this By locator, int? timeoutInSeconds)
        {
            try
            {
                return ExplicitWaitFactory
                    .WaitForVisibilityOfElement(locator, timeoutInSeconds)
                    .Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool IsElementDisplayed(this By locator)
        {
            return IsElementDisplayed(locator,null);
        }


    }
}
