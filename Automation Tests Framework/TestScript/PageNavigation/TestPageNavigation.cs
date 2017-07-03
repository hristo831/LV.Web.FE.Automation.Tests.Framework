using Automation_Tests_Framework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Automation_Tests_Framework.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            INavigation page = ObjectRepository.Driver.Navigate();
            page.GoToUrl(ObjectRepository.Config.GetWebsite());
        }
    }
}
