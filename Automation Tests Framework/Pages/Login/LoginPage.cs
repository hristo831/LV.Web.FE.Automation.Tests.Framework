using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation_Tests_Framework.Pages.Login
{
    public  partial class LoginPage
    {
        [FindsBy(How = How.Id, Using = "inputBank")]
        public IWebElement Bank { get; set; }

        [FindsBy(How = How.Id, Using = "inputLogin")]
        public IWebElement LoginName { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement LoginButton { get; set; }
    }
}
