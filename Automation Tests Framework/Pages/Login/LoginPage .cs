using System;
using System.Threading;
using Automation_Tests_Framework.Configuration;
using Automation_Tests_Framework.Settings;
using OpenQA.Selenium;

namespace Automation_Tests_Framework.Pages.Login
{
    public  partial class LoginPage
    {
        private void EnterBankName(string bankName = null)
        {
            bankName = bankName ?? ObjectRepository.Config.GetBankName();
            Bank.Clear();
            Bank.SendKeys(bankName);
        }

        private void EnterLoginName(string loginName = null)
        {
            loginName = loginName ?? ObjectRepository.Config.GetUsername();
            LoginName.Clear();
            LoginName.SendKeys(loginName);
        }

        private void EnterPassword(string password = null)
        {
            password = password ?? ObjectRepository.Config.GetPassword();
            Password.Clear();
            Password.SendKeys(password);
        }

        private void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void FullLogin()
        {
            EnterBankName();
            EnterLoginName();
            EnterPassword();
            ClickLoginButton();
        }

        
    }
}
