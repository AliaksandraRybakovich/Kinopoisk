using KinopoiskTests.Steps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    [Order(1)]
    public class CheckExtentesPageSteps
    {
        [Given(@"I follow to the Home Page\tas a guest")]
        public void GivenIFollowToTheHomePageAsAGuest()
        {
        }
        
        [Given(@"I click on button extented button search")]
        public void GivenIClickOnButtonExtentedButtonSearch()
        {
            HomeSteps.ClickOnButtonExtSearch();
        }
        
        [Then(@"As a the result I see Extented Search Page")]
        public void ThenAsATheResultISeeExtentedSearchPage()
        {
            bool checkSearchPage = ExtentedSearchSteps.CheckExtentedSearch();

            Assert.IsTrue(checkSearchPage, "You didn't to the extented search page");
        }
    }
}
