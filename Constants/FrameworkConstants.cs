namespace selenium_csharp_ui_automation_framework.Constants
{
    public static class FrameworkConstants
    {
        public static readonly string basePath = Directory.GetCurrentDirectory();
        public static readonly string configFilePath = Path.Combine(basePath, "testdata", "Config.json");
        public static readonly string htmlReportFilePath = Path.Combine(basePath, "htmlreport", "ExtentReport.html");
    }
}
