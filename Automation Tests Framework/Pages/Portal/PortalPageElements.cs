using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation_Tests_Framework.Pages.Portal
{
    public partial class PortalPage
    {
       [FindsBy(How = How.Id, Using = "home-dropdown")]
       public IWebElement HomeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='search-control']/input")]
        public IWebElement UniversalSearch { get; set; }
    }
}
