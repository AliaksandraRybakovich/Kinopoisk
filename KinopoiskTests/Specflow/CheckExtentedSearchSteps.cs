﻿using KinopoiskTests.Entities;
using KinopoiskTests.Steps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class CheckExtentedSearchSteps
    {
        [Given(@"I use extente search on Kinopoisk")]
        public void GivenIUseExtenteSearchOnKinopoisk()
        {
        }
        
        [When(@"I add parameters (.*) and (.*)")]
        public void WhenIAddParametersУнесённыеПризракамиAnd(string nameOfFilm, string year)
        {
            ExtentedSearchInfo searchData = new ExtentedSearchInfo(nameOfFilm, year);
            ExtentedSearchSteps.EnterDataForExtSearch(searchData.NameOfFilms, searchData.YearFilm);
            SearchResultsSteps.GoTOLinkFilm();
        }
        
        [Then(@"the result I found a current film with parameters (.*) and (.*)")]
        public void ThenTheResultIFoundACurrentFilm(string nameOfFilm, string year)
        {
            ExtentedSearchInfo searchData = new ExtentedSearchInfo(nameOfFilm, year);
            bool checkSearchFilm = FilmInfoSteps.CheckFilm(searchData.NameOfFilms, searchData.YearFilm);

            Assert.IsTrue(checkSearchFilm, "This film didn't coincide with given parameter");
        }
    }
}
