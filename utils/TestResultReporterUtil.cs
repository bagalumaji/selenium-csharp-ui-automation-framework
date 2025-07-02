using NUnit.Framework.Interfaces;
using selenium_csharp_ui_automation_framework.reports;

namespace selenium_csharp_ui_automation_framework.utils
{
    public static class TestResultReporterUtil
    {
        public static void ReportTestOutcome()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            switch (status)
            {
                case TestStatus.Failed:
                    ExtentLogger.Fail(TestContext.CurrentContext.Result.Message);
                    break;

                case TestStatus.Passed:
                    ExtentLogger.Pass();
                    break;

                case TestStatus.Skipped:
                case TestStatus.Inconclusive:
                    ExtentLogger.Skip();
                    break;
            }
        }
    }
}
