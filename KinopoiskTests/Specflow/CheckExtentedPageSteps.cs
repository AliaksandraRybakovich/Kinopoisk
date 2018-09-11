using KinopoiskTests.Steps;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class CheckExtentedPageSteps
    {
        [Given(@"I have Home Page Kinopoisk")]
        public void GivenIHaveHomePageKinopoisk()
        {
        }
        
        [When(@"I click on betton extente search page")]
        public void WhenIClickOnBettonExtenteSearchPage()
        {
            HomeSteps.ClickOnButtonExtSearch();
        }
        
        [Then(@"the result I see Extente search from Kinopoisk")]
        public void ThenTheResultISeeExtenteSearchFromKinopoisk()
        {
            bool checkSearchPage = ExtentedSearchSteps.CheckExtentedSearch();

            Assert.IsTrue(checkSearchPage, "You didn't to the extented search page");
        }
    }
}
