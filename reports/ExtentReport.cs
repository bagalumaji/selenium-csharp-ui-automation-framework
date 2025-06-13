using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace selenium_csharp_ui_automation_framework.reports
{
    public class ExtentReport
    {
        public static ExtentReports InitReport()
        {
            var extent = new ExtentReports();
            var htmlReporter = new ExtentSparkReporter("Reports/ExtentReport.html");
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Browser", "Chrome");
            extent.AttachReporter(htmlReporter);
            return extent;
        }
        public static void CreateTest(string testName)
        {
            
        }

        public static void FlushReport(ExtentReports extent)
        {
            ExtentManger.Unload();
        }
    }
}
