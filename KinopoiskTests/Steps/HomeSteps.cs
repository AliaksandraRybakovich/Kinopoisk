using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();

        public static bool CheckLogo()
        {            
            Browser.Browser.CheckStateLoading();
            bool isAssertLogo = false;
            if (homePage.Logo.Displayed)
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
            homePage.Logo.Click();
            SelectElement dropdown = new SelectElement(homePage.Logo);
            dropdown.SelectByText(textDropdown.Logout);
            return new LogPage();
        }
    }
}
