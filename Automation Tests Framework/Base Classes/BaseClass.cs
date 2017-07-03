using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation_Tests_Framework.Configuration;
using Automation_Tests_Framework.CustomExeption;
using Automation_Tests_Framework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Automation_Tests_Framework.Base_Classes
{
    [TestClass]
    public class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }

        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            return options;
        }

        private static IWebDriver GetChromeDriver() 
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver; 
        }

        private static IWebDriver GetIExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIExplorerDriver();
                    break;

                default:
                    throw new NoSutiableDriverFound("Driver Not Found : " +
                                                    ObjectRepository.Config.GetBrowser().ToString());
            }
        }

        [AssemblyCleanupAttribute]
        public static void TearDown()
            {
                if (ObjectRepository.Driver != null)
                {
                    ObjectRepository.Driver.Close();
                    ObjectRepository.Driver.Quit();
                }
            }
    }
}
