using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using selenium_csharp_ui_automation_framework.config;

namespace selenium_csharp_ui_automation_framework.reports
{
    public class ExtentReport
    {
        private static ExtentReports extent = new ExtentReports();
        public static ExtentReports InitReport()
        {
            var htmlReporter = new ExtentSparkReporter("ExtentReport.html");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Browser", ConfigReader.GetConfig().Browser);
            extent.AddSystemInfo("OS", "Windows 10");
            extent.AddSystemInfo("Framework", "Selenium C# UI Automation Framework");
            htmlReporter.Config.DocumentTitle = "Selenium C# UI Automation Framework Report";
            extent.AttachReporter(htmlReporter);
            return extent;
        }
        public static void CreateTest(string testName)
        {
            ExtentManger.GetExtentTest = extent.CreateTest(testName);
        }

        public static void FlushReport(ExtentReports extent)
        {
            ExtentManger.Unload();
        }
    }
}
