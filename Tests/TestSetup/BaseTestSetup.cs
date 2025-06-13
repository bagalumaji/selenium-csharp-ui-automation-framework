using selenium_csharp_ui_automation_framework.reports;

namespace selenium_csharp_ui_automation_framework.Tests.TestSetup
{
    public class BaseTestSetup
    {
        [OneTimeSetUp]
        public void BeforeAll()
        {
            ExtentReport.InitReport();
        }
        [OneTimeTearDown]
        public void AfterAll()
        {
            ExtentReport.FlushReport();
        }
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
