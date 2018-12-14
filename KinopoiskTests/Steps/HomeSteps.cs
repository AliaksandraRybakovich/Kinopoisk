using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();

        public static ExtentedSearchPage ClickOnExtentedSearchButton()
        {
            homePage.ExtentedSearchButton.Click();
            return new ExtentedSearchPage();
        }

        public static LogPage ClickOnLogOutButton()
        {
            homePage.Logo.Click();
            homePage.LogOut.Click();
            return new LogPage();
        }        
    }
}

