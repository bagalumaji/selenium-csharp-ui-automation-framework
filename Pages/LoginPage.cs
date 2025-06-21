
using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.PageAction;
using selenium_csharp_ui_automation_framework.reports;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class LoginPage : BasePage
    {
        private static By UserNameTextBox => By.Id("user-name");
        private static By PasswordTextBox =>By.Id("password");
        private static By LoginButton => By.Name("login-button");

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
            ExtentLogger.Info("Entering
            PasswordTextBox.SendKeysToElement(password);
        }
        public void login(string userName, string password)
        {
            EnterUserName(userName);
            EnterPassword(password);
            ClickLoginButton();
        }
        public bool IsLoginButtonDisplayed()
        {
            return LoginButton.IsElementDisplayed();
        }
        public void verifyThatLoginButtonIsDisplayed()
        {
            ExtentLogger.Info("Verifying that login button is displayed on the page");
            Assert.That(IsLoginButtonDisplayed(), "Login button is not displayed on the page.");
        }
    }
}
