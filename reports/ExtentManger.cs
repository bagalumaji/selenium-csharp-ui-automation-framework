using AventStack.ExtentReports;

namespace selenium_csharp_ui_automation_framework.reports
{
    public class ExtentManger
    {
        private static readonly  ThreadLocal<ExtentTest> _extentTest = new();

        public static ExtentTest GetExtentTest()
        {
            return _extentTest.Value;
        }

        public static void SetExtentTest(ExtentTest extent)
        {
           _extentTest.Value = extent;
        }
        public static void Unload()
        {
            if (_extentTest.Value != null && _extentTest.IsValueCreated)
            {
                _extentTest.Value = null;
               _extentTest.Dispose();
            }
        }
    }
}
