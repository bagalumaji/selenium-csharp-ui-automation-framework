
using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.PageAction;
using selenium_csharp_ui_automation_framework.reports;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By UserNameTextBox = By.Id("user-name");
        private readonly By PasswordTextBox = By.Id("password");
        private readonly By LoginButton = By.XPath("//input[@value='Login' or @type='submit']");

        public void ClickLoginButton()
        {
            ExtentLogger.Info("Clicking on Login button");
            LoginButton.ClickOnElement();
        }

        public void EnterUserName(string userName)
        {
            ExtentLogger.Info("Entering username: " + userName);
            UserNameTextBox.SendKeysToElement(userName);
        }
        public void EnterPassword(string password)
        {
            ExtentLogger.Info("Entering password: " + password);
            PasswordTextBox.SendKeysToElement(password);
        }
        public void LoginToApplication(string userName, string password)
        {
            EnterUserName(userName);
            EnterPassword(password);
            ClickLoginButton();
        }
        public bool IsLoginButtonDisplayed()
        {
            return LoginButton.IsElementDisplayed();
        }
        public void VerifyThatLoginButtonIsDisplayed()
        {
            ExtentLogger.Info("Verifying that LoginToApplication button is displayed on the page");
            Assert.That(IsLoginButtonDisplayed(), "Login button is not displayed on the page.");
        }
    }
}
