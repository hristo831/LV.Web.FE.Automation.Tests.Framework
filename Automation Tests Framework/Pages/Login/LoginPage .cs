using Automation_Tests_Framework.Configuration;
using OpenQA.Selenium;

namespace Automation_Tests_Framework.Pages.Login
{
    public  partial class LoginPage
    {
        private LoginPage BankName(string bankName = null)
        {
            AppConfigReader getBankName = new AppConfigReader();
            bankName = bankName ?? getBankName.GetBankName();
            Bank.Clear();
            Bank.SendKeys(bankName);
            return this;
        }

        public 
    }
}
