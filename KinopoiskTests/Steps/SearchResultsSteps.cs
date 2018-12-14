using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class SearchResultsSteps
    {
        static SearchResultsPage searchResultsPage = new SearchResultsPage();

        public static FilmInfoPage ClickOnMovieRerference()
        {
            searchResultsPage.LinkFilm.Click();
            return new FilmInfoPage();
        }
      
    }
}
