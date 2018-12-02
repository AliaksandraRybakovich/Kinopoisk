using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class ExtentedSearchSteps
    {
        static ExtentedSearchPage extentedSearchPage = new ExtentedSearchPage();
        
        public static void EnterDataForExtSearch(ExtentedSearchInfo searchInfo)
        {
            extentedSearchPage.TextboxName.Click();
            extentedSearchPage.TextboxName.SendKeys(searchInfo.NameOfFilms);

            extentedSearchPage.TextboxYear.Click();
            extentedSearchPage.TextboxYear.SendKeys(searchInfo.Year);

            extentedSearchPage.ButtonSearch.Click();
        }

        public static void EnterDataForExtSearch(string nemaOfFilm, string year)
        {
            extentedSearchPage.TextboxName.Click();
            extentedSearchPage.TextboxName.SendKeys(nemaOfFilm);

            extentedSearchPage.TextboxYear.Click();
            extentedSearchPage.TextboxYear.SendKeys(year);

            extentedSearchPage.ButtonSearch.Click();
        }
    }
}
