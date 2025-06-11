using selenium_csharp_ui_automation_framework.enums;
using selenium_csharp_ui_automation_framework.exceptions;

namespace selenium_csharp_ui_automation_framework.convertors
{
    public static class StringToBrowserTypeConvertor
    {
        public static BrowserTypes Convert(string browserType)
        {
            try
            {
                return Enum.Parse<BrowserTypes>(browserType.ToUpper());
            }
            catch (ArgumentException)
            {
                throw new BrowserTypeNotSupportedException(browserType);
            }
        }
    }
}
