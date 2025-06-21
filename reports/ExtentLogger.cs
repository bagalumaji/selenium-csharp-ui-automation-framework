using selenium_csharp_ui_automation_framework.utils;

namespace selenium_csharp_ui_automation_framework.reports
{
    public static class ExtentLogger
    {
        public static void Info(string message)=>ExtentManger.GetExtentTest().Info(message);
        public static void Pass(string message)=>ExtentManger.GetExtentTest().Pass(TestCaseNameUtil.GetTestCaseName() + message);
        public static void Pass()=> ExtentManger.GetExtentTest().Pass(TestCaseNameUtil.GetTestCaseName()+ " Test passed successfully.");
        public static void Fail(string message) =>  ExtentManger.GetExtentTest().Fail(TestCaseNameUtil.GetTestCaseName() + message);
        public static void Fail() => ExtentManger.GetExtentTest().Fail(TestCaseNameUtil.GetTestCaseName() + " Test Failed");
    }
}
