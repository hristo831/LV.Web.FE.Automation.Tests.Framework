using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation_Tests_Framework.Interfaces;
using OpenQA.Selenium;

namespace Automation_Tests_Framework.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }

        public static IWebDriver Driver { get; set; }
    }
}
