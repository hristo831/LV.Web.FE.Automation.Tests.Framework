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
            try
            {
                return (BrowserType) Enum.Parse(typeof (BrowserType), browser);
            }
            catch (Exception)
            {
                return null;
            }
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

        public int GetPageLoadTimeOut()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeout);
            if (timeout == null)
            {
                return 30;
            }
            return Convert.ToInt32(timeout);
        }

        public int GetElementLoadTimeOut()
        {
            string timeout = ConfigurationManager.AppSettings.Get((AppConfigKeys.ElementLoadTimeout));
            if (timeout == null)
            {
                return 30;
            }
            return Convert.ToInt32(timeout);
        }
    }
}
