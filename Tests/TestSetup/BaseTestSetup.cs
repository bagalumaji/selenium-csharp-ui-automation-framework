using selenium_csharp_ui_automation_framework.DriverInfo;

namespace selenium_csharp_ui_automation_framework.Tests.TestSetup
{
    public class BaseTestSetup
    {

        [SetUp]
        public void Setup()
        {
            Driver.InitDriver();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
