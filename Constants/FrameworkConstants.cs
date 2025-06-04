using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_csharp_ui_automation_framework.Constants
{
    public static class FrameworkConstants
    {
        public static readonly string basePath = Directory.GetCurrentDirectory();
        public static readonly string configFilePath = Path.Combine(basePath, "testdata", "Config.json");
    }
}
