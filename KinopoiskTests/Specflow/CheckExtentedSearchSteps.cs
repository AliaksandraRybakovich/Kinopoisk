using KinopoiskTests.Entities;
using KinopoiskTests.Steps;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    [Order(2)]
    public class CheckExtentedSearchSteps
    {
        [Given(@"I input parameters (.*) and (.*)")]
        public void GivenIInputParametersAnd(string nameOfFilm, string year)
        {
            ExtentedSearchInfo searchParameters = new ExtentedSearchInfo();
            ExtentedSearchSteps.EnterDataForExtSearch(nameOfFilm, year);
        }
        
        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
        }
        
        [Then(@"I see the current film with parameter (.*) and (.*)")]
        public void ThenISeeTheCurrentFilmWithParameterAnd(string nameOfFilm, string year)
        {
            ExtentedSearchInfo searchParameters = new ExtentedSearchInfo();
            bool checkSearchFilm = FilmCurrentSteps.CheckFilm(nameOfFilm, year);
            FilmsSteps.GoTOLinkFilm();

            Assert.IsTrue(checkSearchFilm, "This film didn't coincide with given parameter");
        }
    }
}
