
using OpenQA.Selenium;
using selenium_csharp_ui_automation_framework.PageAction;

namespace selenium_csharp_ui_automation_framework.Pages
{
    public class LoginPage : BasePage
    {
        private By UserNameTextBox => By.Id("user-name");
        private By PasswordTextBox =>By.Id("password");
        private By LoginButton => By.Name("login-button");

        public void ClickLoginButton()
        {
            LoginButton.ClickOnElement();
        }

        public void EnterUserName(string userName)
        {
            UserNameTextBox.SendKeysToElement(userName);
        }
        public void EnterPassword(string password)
        {
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
            Assert.That(IsLoginButtonDisplayed(), "Login button is not displayed on the page.");
        }
    }
}
