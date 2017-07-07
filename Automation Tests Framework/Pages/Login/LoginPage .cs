using System.Threading;
using Automation_Tests_Framework.Configuration;
using OpenQA.Selenium;

namespace Automation_Tests_Framework.Pages.Login
{
    public  partial class LoginPage
    {
        readonly AppConfigReader _getBankName = new AppConfigReader();
        private void BankName(string bankName = null)
        {
            bankName = bankName ?? _getBankName.GetBankName();
            Bank.Clear();
            Bank.SendKeys(bankName);
            //return this;
        }

        public void FullLogin()
        {
            BankName();
        }
    }
}
