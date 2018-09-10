using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();
        static WebDriverWait wait = new WebDriverWait(Browser.Browser.GetDriver(), TimeSpan.FromSeconds(15));

        public static bool CheckLogo()
        {
            Browser.Browser.SwitchToWindow();
            bool isAssertLogo = false;
            if (Browser.Browser.CheckStateLoading())
            {
                isAssertLogo = true;
            }
            return isAssertLogo;
        }
          
        public static ExtentedSearchPage ClickOnButtonExtSearch()
        {
            homePage.ButtonExtendedSearch.Click();
            return new ExtentedSearchPage();
        }

        public static LogPage ClickOnLogOut(FieldForDropDown textDropdown)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(homePage.Logo));
            homePage.Logo.Click();
            homePage.LogOut.Click();
            return new LogPage();
        }
    }
}
