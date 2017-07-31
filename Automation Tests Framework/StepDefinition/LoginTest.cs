using Automation_Tests_Framework.Pages;
using Automation_Tests_Framework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Automation_Tests_Framework.StepDefinition
{
    [Binding]
    public sealed class LoginTest
    {
        [Given(@"Go to Login Page")]
        public void GivenGoToLoginPage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }


        [Given(@"Login")]
        public void GivenLogin()
        {
            PageObjects.LoginPage.FullLogin();
        }


        [Then(@"I am on Portal page")]
        public void ThenIAmOnPortalPage()
        {
            Assert.IsTrue(PageObjects.PortalPage.HomeDropdown.Displayed);
        }



    }
}
