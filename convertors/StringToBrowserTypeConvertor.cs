using selenium_csharp_ui_automation_framework.enums;

namespace selenium_csharp_ui_automation_framework.convertors
{
    public static class StringToBrowserTypeConvertor
    {
        public static BrowserTypes Convert(string browserType)
        {
                return Enum.Parse<BrowserTypes>(browserType);
        }
    }
}
