using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();
          
        public static ExtentedSearchPage ClickOnButtonExtSearch()
        {
            homePage.ButtonExtendedSearch.Click();
            return new ExtentedSearchPage();
        }
    }
}
