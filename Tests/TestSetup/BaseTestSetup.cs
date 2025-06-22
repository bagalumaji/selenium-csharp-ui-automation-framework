using selenium_csharp_ui_automation_framework.driver;
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
            Driver.InitDriver();
            ExtentReport.CreateTest();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
