﻿using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.driver;
namespace selenium_csharp_ui_automation_framework.Pages
{
    abstract public class BasePage
    {
        protected IWebDriver driver;
        protected BasePage()
        {
            this.driver = DriverManager.GetDriver();
        }
    }
}
