using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();

        public static void ClickOnButtonExtSearch()
        {
            homePage.ButtonExtendedSearch.Click();
        }

        public static void ClickOnLogOutForSpecflow()
        {
            Browser.Browser.SwitchToWindow();
            homePage.Logo.Click();
            homePage.LogOut.Click();
        }

        public static void ClickOnLogOut()
        {
            homePage.Logo.Click();
            homePage.LogOut.Click();
        }
    }
}

