using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.PageAction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class HomePage : BasePage
    {
        IWebElement TitleProduct => this.driver.FindElement(By.XPath("//span[normalize-space()='Products']"));

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
