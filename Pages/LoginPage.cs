
using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.PageAction;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class LoginPage : BasePage
    {
        By UserNameTextBox = By.Id("user-name");
        By PasswordTextBox = By.Id("password");
        By LoginButton = By.Name("login-button");

        public void ClickLoginButton()
        {
            PageActions.click(this.driver.FindElement(LoginButton));
        }

        public void EnterUserName(string userName)
        {
            PageActions.sendKeys(this.driver.FindElement(UserNameTextBox),userName);
        }
        public void EnterPassword(string password)
        {
            PageActions.sendKeys(this.driver.FindElement(PasswordTextBox),password);
        }
        public void login(string userName, string password)
        {
            EnterUserName(userName);
            EnterPassword(password);
            ClickLoginButton();
        }
        public bool IsLoginButtonDisplayed()
        {
            return PageActions.isElementDisplayed(this.driver.FindElement(LoginButton));
        }
        public void verifyThatLoginButtonIsDisplayed()
        {
            Assert.That(IsLoginButtonDisplayed(), "Login button is not displayed on the page.");
        }
    }
}
