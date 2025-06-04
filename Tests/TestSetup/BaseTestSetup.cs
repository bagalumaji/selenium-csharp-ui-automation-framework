namespace selenium_csharp_ui_automation_framework.Tests.TestSetup
{
    public class BaseTestSetup
    {

        [SetUp]
        public void Setup()
        {
            driver.Driver.InitDriver();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Driver.QuitDriver();
        }
    }
}
