using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class LogSteps
    {
        static LogPage logPage = new LogPage();

        public static AuthorizationPage LogIn()
        {
            logPage.login.Click();
            return new AuthorizationPage();
        }

        public static bool CheckLogOutPage()
        {
            bool isAssertLogout = false;
            if (Browser.Browser.CheckStateLoading())
            {
                isAssertLogout = true;
            }
            return isAssertLogout;
        }
    }
}
