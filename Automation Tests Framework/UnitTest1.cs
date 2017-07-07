using System;
using Automation_Tests_Framework.Pages;
using Automation_Tests_Framework.Pages.Login;
using Automation_Tests_Framework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation_Tests_Framework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            PageObjects.LoginPage.FullLogin();
        }
    }
}
