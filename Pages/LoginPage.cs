
using OpenQA.Selenium;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class LoginPage : BasePage
    {
        By UserNameTextBox = By.Id("user-name");
        By PasswordTextBox = By.Id("password");
        By LoginButton = By.Name("login-button");

        public void clickLoginButton()
        {
            this.driver.FindElement(LoginButton).Click();
        }

        public void enterUserName(string userName)
        {
            this.driver.FindElement(UserNameTextBox).SendKeys(userName);
        }
        public void enterPassword(string password)
        {
            this.driver.FindElement(PasswordTextBox).SendKeys(password);
        }
        public void login(string userName, string password)
        {
            enterUserName(userName);
            enterPassword(password);
            clickLoginButton();
        }
        public bool isLoginButtonDisplayed()
        {
            return this.driver.FindElement(LoginButton).Displayed;
        }
        public void verifyThatLoginButtonIsDisplayed()
        {
            Assert.That(isLoginButtonDisplayed(), "Login button is not displayed on the page.");
        }
    }
}
