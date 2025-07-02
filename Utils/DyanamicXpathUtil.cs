using OpenQA.Selenium;

namespace selenium_csharp_ui_automation_framework.Utils
{
    public class DyanamicXpathUtil
    {
        public static By GetDynamicXpath(string xpath, string value) => By.XPath(xpath.Replace("{value}", value));
    }
}
