using Microsoft.Extensions.Configuration;
using selenium_csharp_ui_automation_framework.Constants;
using selenium_csharp_ui_automation_framework.exceptions;
using selenium_csharp_ui_automation_framework.poco;

namespace selenium_csharp_ui_automation_framework.config
{
    public static class ConfigReader
    {
        private static readonly IConfiguration _configReader;
        private static readonly Config _cachedConfig;

        static ConfigReader()
        {
            if (!File.Exists(FrameworkConstants.configFilePath))
            {
                throw new ConfigFileNotFoundException($"Missing config file at: {FrameworkConstants.configFilePath}");
            }

            _configReader = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(FrameworkConstants.configFilePath, optional: false, reloadOnChange: true)
                .Build();

            _cachedConfig = _configReader.Get<Config>()
                ?? throw new ConfigFileNotFoundException("Failed to load config into POCO. File might be not well structured...");
        }

        public static Config GetConfig() => _cachedConfig;
    }
}