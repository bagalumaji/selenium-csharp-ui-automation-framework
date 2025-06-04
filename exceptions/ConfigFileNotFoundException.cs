using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_csharp_ui_automation_framework.exceptions
{
    public class ConfigFileNotFoundException : Exception
    {
        public ConfigFileNotFoundException(string message) :base(message){ }
    }
}
