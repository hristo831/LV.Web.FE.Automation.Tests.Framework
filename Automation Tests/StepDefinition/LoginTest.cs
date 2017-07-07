using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Automation_Tests.StepDefinition
{
    [Binding]
    public sealed class LoginTest
    {
        [Given(@"Go to Login Page")]
        public void GivenGoToLoginPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am on the Login Page")]
        public void ThenIAmOnTheLoginPage()
        {
            Assert.IsFalse(true);
        }


    }
}
