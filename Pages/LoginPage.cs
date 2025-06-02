
using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.PageAction;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class LoginPage : BasePage
    {
        By UserNameTextBox = By.Id("user-name");
        By PasswordTextBox = By.Id("password");
        By LoginButton = By.Name("login-button");

        public void clickLoginButton()
        {
            PageActions.click(this.driver.FindElement(LoginButton));
        }

        public void enterUserName(string userName)
        {
            PageActions.sendKeys(this.driver.FindElement(UserNameTextBox),userName);
        }
        public void enterPassword(string password)
        {
            PageActions.sendKeys(this.driver.FindElement(PasswordTextBox),password);
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
