using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.PageAction;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class ProductsPage : BasePage
    {
        private static By TitleProduct => By.XPath("//span[normalize-space()='Products']");

        public bool IsTitleProductDisplayed()
        {
            return TitleProduct.IsElementDisplayed(ConfigReader.GetConfig().Timeout.DefaultTimeout);
        }
        public void VerifyThatTitleProductIsDisplayed()
        {
            Assert.That(IsTitleProductDisplayed(), "Title 'Products' is not displayed on the page.");
        }
    }
}
