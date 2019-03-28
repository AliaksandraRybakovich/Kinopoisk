using KinopoiskTests.Steps;
using System;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class TestExtentedSearchBDDSteps
    {
        [Given(@"I follow to Log Page as a unregistered user")]
        public void GivenIFollowToHomePageAsAUnregisteredUser()
        {
            //new LogSteps();
        }
        
        [Given(@"I click on button \*Extented Search\*")]
        public void GivenIClickOnButtonExtentedSearch()
        {
            //LogSteps.ClickOnExtentedSearchButton();
        }
        
        [Given(@"I enter (.*) and (.*)")]
        public void GivenIEnter(string NameOfFilm, string YearFilm)
        {
            //ExtentedSearchSteps.EnterDataForExtSearch(NameOfFilm, YearFilm);
        }
        
        [Given(@"I click on button \*Search\*")]
        public void GivenIClickOnButtonSearch()
        {
            //SearchResultsSteps.ClickOnMovieRerference();
        }
        
        [When(@"I click on movie references")]
        public void WhenIClickOnMovieReferences()
        {
            //SearchResultsSteps.ClickOnMovieRerference();
        }
        
        [Then(@"the result should be certain film of search")]
        public void ThenTheResultShouldBeCertainFilmOfSearch()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
