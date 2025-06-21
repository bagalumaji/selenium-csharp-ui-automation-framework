using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.Constants;
using selenium_csharp_ui_automation_framework.utils;

namespace selenium_csharp_ui_automation_framework.reports
{
    public class ExtentReport
    {
        private static ExtentReports? extent = null;

        public static void InitReport()
        {
            extent ??= CreateExtentReports();
        }

        private static ExtentReports CreateExtentReports()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentSparkReporter(FrameworkConstants.htmlReportFilePath);
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Browser", ConfigReader.GetConfig().Browser);
            extent.AddSystemInfo("OS", "Windows 10");
            extent.AddSystemInfo("Framework", "Selenium C# UI Automation Framework");
            htmlReporter.Config.DocumentTitle = "Selenium C# UI Automation Framework Report";
            extent.AttachReporter(htmlReporter);
            return extent;
        }
        public static void CreateTest()
        {
            extent ??= CreateExtentReports();
            ExtentManger.SetExtentTest(extent.CreateTest(TestCaseNameUtil.GetTestCaseName()));
        }

        public static void FlushReport()
        {
            extent?.Flush();
            ExtentManger.Unload();
        }
    }
}
