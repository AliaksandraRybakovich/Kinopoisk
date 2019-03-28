using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();

        public static YandexLogInPage ChooseLogIn()
        {
            homePage.Login.Click();
            Browser.Browser.SwitchToFrame(homePage.IFrame);
            homePage.HaveAccount.Click();
            homePage.YandexButton.Click();
            return new YandexLogInPage();
        }

        public static void ClickOnLogOutButton()
        {
            homePage.Logo.Click();
            homePage.LogOut.Click();
        }

        public static ExtentedSearchPage ClickOnExtentedSearchButton()
        {
            homePage.ExtentedSearchButton.Click();
            return new ExtentedSearchPage();
        }        
    }
}

