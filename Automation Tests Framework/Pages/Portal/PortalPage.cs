using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Tests_Framework.Pages.Portal
{
    public partial class PortalPage
    {
        public void TypeInUniversalSearch(string text )
        {
            UniversalSearch.Clear();
            UniversalSearch.SendKeys(text);
        }
    }
}
