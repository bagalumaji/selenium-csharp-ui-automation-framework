namespace selenium_csharp_ui_automation_framework.exceptions
{
    public class BrowserTypeNotSupportedException : ArgumentException
    {
        public BrowserTypeNotSupportedException(string browserType)
            : base($"Browser type '{browserType}' is not supported. Please use a supported browser types....")
        {
        }
        public BrowserTypeNotSupportedException(string browserType, Exception innerException)
          : base($"Browser type '{browserType}' is not supported.", innerException)
        {
        }
    }
}
