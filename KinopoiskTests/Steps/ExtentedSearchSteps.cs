using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class ExtentedSearchSteps
    {
        static ExtentedSearchPage extentedSearchPage = new ExtentedSearchPage();
        public static bool CheckExtentedSearch()
        {
            bool isAssertExtentedSearch = false;
            if (extentedSearchPage.checkSuccess.Displayed)
            {
                isAssertExtentedSearch = true;
            }
            return isAssertExtentedSearch;
        }

        public static FilmsPage EnterDataForExtSearch(ExtentedSearchInfo searchInfo)
        {
            extentedSearchPage.textboxName.Click();
            extentedSearchPage.textboxName.SendKeys(searchInfo.NameOfFilms);

            extentedSearchPage.textboxYear.Click();
            extentedSearchPage.textboxYear.SendKeys(searchInfo.Year);

            extentedSearchPage.buttonSearch.Click();
            return new FilmsPage();
        }

        public static FilmsPage EnterDataForExtSearch(string nemaOfFilm, string year)
        {
            extentedSearchPage.textboxName.Click();
            extentedSearchPage.textboxName.SendKeys(nemaOfFilm);

            extentedSearchPage.textboxYear.Click();
            extentedSearchPage.textboxYear.SendKeys(year);

            extentedSearchPage.buttonSearch.JavaScriptExecutor();
            return new FilmsPage();
        }
    }
}
