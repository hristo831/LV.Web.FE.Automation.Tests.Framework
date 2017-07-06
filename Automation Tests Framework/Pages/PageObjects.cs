using Automation_Tests_Framework.Settings;
using OpenQA.Selenium.Support.PageObjects;
using Automation_Tests_Framework.Pages;
using Automation_Tests_Framework.Pages.Login;

namespace Automation_Tests_Framework.Pages
{
    class PageObjects
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(ObjectRepository.Driver, page);
            return page;
        }

        public static LoginPage LoginPage
        {
            get { return GetPage<LoginPage>(); }
        }
    }
}
