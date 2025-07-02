using AventStack.ExtentReports;

namespace selenium_csharp_ui_automation_framework.reports
{
    public class ExtentManger
    {
        private static ThreadLocal<ExtentTest>? _extentTest = new();

        public static ExtentTest? GetExtentTest() => _extentTest?.Value;

        public static void SetExtentTest(ExtentTest extent)
        {
            _extentTest ??= new ThreadLocal<ExtentTest>();
            _extentTest.Value = extent;
        }

        public static void Unload()
        {
            if (_extentTest?.Value != null && _extentTest.IsValueCreated)
            {
                _extentTest.Dispose();
                _extentTest.Value = null;
            }
        }
    }
}
