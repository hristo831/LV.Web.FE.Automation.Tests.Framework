using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation_Tests_Framework.Configuration;

namespace Automation_Tests_Framework.Interfaces
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        string GetBankName();
        string GetUsername();
        string GetPassword();
        string GetWebsite();

    }
}
