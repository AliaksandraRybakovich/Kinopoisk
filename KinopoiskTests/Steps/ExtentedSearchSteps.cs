﻿using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class ExtentedSearchSteps
    {
        static ExtentedSearchPage extentedSearchPage = new ExtentedSearchPage();
        
        public static SearchResultsPage EnterDataForExtSearch(ExtentedSearchInfo searchInfo)
        {
            extentedSearchPage.NameTextbox.Click();
            extentedSearchPage.NameTextbox.SendKeys(searchInfo.NameOfFilm);

            extentedSearchPage.YearTextbox.Click();
            extentedSearchPage.YearTextbox.SendKeys(searchInfo.YearFilm);

            extentedSearchPage.SearchButton.Click();
            return new SearchResultsPage();
        }

        public static void EnterDataForExtSearch(string nemaOfFilm, string year)
        {
            extentedSearchPage.NameTextbox.Click();
            extentedSearchPage.NameTextbox.SendKeys(nemaOfFilm);
            
            extentedSearchPage.YearTextbox.Click();
            extentedSearchPage.YearTextbox.SendKeys(year);

            extentedSearchPage.SearchButton.Click(); 
        }
    }
}
