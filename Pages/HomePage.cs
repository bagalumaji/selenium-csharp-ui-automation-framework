using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class HomePage : BasePage
    {
        By titleProduct = By.XPath("//span[normalize-space()='Products']");

        public bool isTitleProductDisplayed()
        {
            try
            {
                return this.driver.FindElement(titleProduct).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void verifyThatTitleProductIsDisplayed()
        {
            Assert.That(isTitleProductDisplayed(), "Title 'Products' is not displayed on the page.");   
        }

    }
}
