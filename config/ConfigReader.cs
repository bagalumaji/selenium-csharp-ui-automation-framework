using Microsoft.Extensions.Configuration;
using selenium_csharp_ui_automation_framework.Constants;
using selenium_csharp_ui_automation_framework.exceptions;
using selenium_csharp_ui_automation_framework.poco;

namespace selenium_csharp_ui_automation_framework.config
{
    public static class ConfigReader
    {
        private static IConfiguration _configReader;

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
           
        }

        public static Config GetTimeoutConfig()
        {
            var timeoutConfig = _configReader.Get<Config>();
            if (timeoutConfig == null)
            {
                throw new ConfigFileNotFoundException(FrameworkConstants.configFilePath + " is missing the configuration file.");
            }
            return timeoutConfig;
        }

    }

}
