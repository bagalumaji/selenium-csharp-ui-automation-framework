namespace selenium_csharp_ui_automation_framework.utils
{
    public static class TestCaseNameUtil
    {
        public static string GetTestCaseName() => TestContext.CurrentContext.Test.Name;
    }
}
