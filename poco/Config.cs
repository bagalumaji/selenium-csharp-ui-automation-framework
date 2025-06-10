namespace selenium_csharp_ui_automation_framework.poco
{
    public class Config
    {
        public required TimeoutConfig Timeout { get; set; }
        public required string Url { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Browser { get; set; }

    }
}
