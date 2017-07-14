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
            PageObjects.LoginPage.FullLogin();
        }

        [Then(@"I am on the Login Page")]
        public void ThenIAmOnTheLoginPage()
        {
            Assert.IsFalse(true);
        }


    }
}
