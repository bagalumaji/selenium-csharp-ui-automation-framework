namespace selenium_csharp_ui_automation_framework.exceptions
{
    public class DriverNotCreatedException : Exception
    {
        public DriverNotCreatedException(string browserType)
            : base($"Browser type '{browserType}' is not supported. Please use a supported browser types....")
        {
        }
        public DriverNotCreatedException(string browserType, Exception innerException)
          : base($"Browser type '{browserType}' is not supported.", innerException)
        {
        }
    }
}
