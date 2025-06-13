using AventStack.ExtentReports;

namespace selenium_csharp_ui_automation_framework.reports
{
    public class ExtentManger
    {
        private static readonly  ThreadLocal<ExtentTest> extentTest = new();

        public static ExtentTest GetExtentTest
        {
            get => extentTest.Value;
            set => extentTest.Value = value;
        }

        public static void Unload()
        {
            extentTest.Value = null;
            extentTest.Dispose();
        }
    }
}
