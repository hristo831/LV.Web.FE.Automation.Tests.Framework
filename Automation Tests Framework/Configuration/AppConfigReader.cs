using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation_Tests_Framework.Interfaces;
using Automation_Tests_Framework.Settings;

namespace Automation_Tests_Framework.Configuration
{
    public  class AppConfigReader : IConfig
    {
        public BrowserType? GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType) Enum.Parse(typeof (BrowserType), browser);
        }

        public  string GetBankName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.BankName);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}
