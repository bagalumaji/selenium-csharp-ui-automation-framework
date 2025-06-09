using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.PageAction;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class HomePage : BasePage
    {
        By TitleProduct => By.XPath("//span[normalize-space()='Products']");

        public bool IsTitleProductDisplayed()
        {
            return TitleProduct.IsElementDisplayed();
        }
        public void VerifyThatTitleProductIsDisplayed()
        {
            Assert.That(IsTitleProductDisplayed(), "Title 'Products' is not displayed on the page.");
        }

    }
}
