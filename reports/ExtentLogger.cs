namespace selenium_csharp_ui_automation_framework.reports
{
    public static class ExtentLogger
    {
        public static void Info(string message)
        {
            ExtentManger.GetExtentTest().Info(message);
        }
        public static void Pass(string message)
        {
            ExtentManger.GetExtentTest().Pass(message);
        }
        public static void Fail(string message)
        {
            ExtentManger.GetExtentTest().Fail(message);
        }
    }
}
