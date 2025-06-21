using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using selenium_csharp_ui_automation_framework.config;
using selenium_csharp_ui_automation_framework.Constants;

namespace selenium_csharp_ui_automation_framework.reports
{
    public class ExtentReport
    {
        private static ExtentReports extent;

        public static void InitReport()
        {
            if (extent == null)
            {
                extent = new ExtentReports();
                var htmlReporter = new ExtentSparkReporter(FrameworkConstants.htmlReportFilePath);
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("Browser", ConfigReader.GetConfig().Browser);
                extent.AddSystemInfo("OS", "Windows 10");
                extent.AddSystemInfo("Framework", "Selenium C# UI Automation Framework");
                htmlReporter.Config.DocumentTitle = "Selenium C# UI Automation Framework Report";
                extent.AttachReporter(htmlReporter);
            }
        }

        public static void CreateTest(string testName)
        {
            Console.WriteLine("test case ...."+TestContext.CurrentContext.Test.Name);
            ExtentManger.SetExtentTest(extent.CreateTest(testName));
        }

        public static void FlushReport()
        {
            extent.Flush(); 
            ExtentManger.Unload();
        }
    }
}
