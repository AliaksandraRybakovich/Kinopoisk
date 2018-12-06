using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();

        public static void ClickOnExtentedSearchButton()
        {
            homePage.ExtentedSearchButton.Click();
        }

        public static void ClickOnLogOutButton()
        {
            homePage.Logo.Click();
            homePage.LogOut.Click();
        }        
    }
}

