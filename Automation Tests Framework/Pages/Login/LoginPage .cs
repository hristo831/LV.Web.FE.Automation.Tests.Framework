using System;
using System.Threading;
using Automation_Tests_Framework.Configuration;
using Automation_Tests_Framework.Settings;
using OpenQA.Selenium;

namespace Automation_Tests_Framework.Pages.Login
{
    public  partial class LoginPage
    {
        private void BankName(string bankName = null)
        {
            //bankName = bankName ?? ObjectRepository.Config.GetBankName();
            //Bank.Clear();
            //Bank.SendKeys(bankName);
            TypeInTextBox(Bank, ObjectRepository.Config.GetBankName());

        }

        private void UserName(string userName = null)
        {
            userName = userName ?? ObjectRepository.Config.GetUsername();

        }

        public void FullLogin()
        {
            BankName();
        }

        public static void TypeInTextBox(IWebElement element, string text)
        {
            //element = GenericHelper.GetElement(locator);
            element.Clear();
            element.SendKeys(text);
            //Logger.Info($" Type in Textbox @ {locator} : value : {text}");
        }

       /* public static IWebElement GetElement(By locator)
        {
            if (IsElemetPresent(locator))
                return ObjectRepository.Driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

        public static bool IsElemetPresent(IWebElement element)
        {
            try
            {
                //Logger.Info(" Checking for the element " + locator);
                return ObjectRepository.Driver.;
            }
            catch (Exception)
            {
                return false;
            }

        }*/
    }
}
