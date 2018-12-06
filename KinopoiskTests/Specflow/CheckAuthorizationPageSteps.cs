using KinopoiskTests.Steps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class CheckAuthorizationPageSteps
    {
        [Given(@"I go to the LogInPage on Kinopoisk")]
        public void GivenIGoToTheLogInPageOnKinopoisk()
        {
            LogSteps.LogIn();
        }
        
        [When(@"I click on the LogIn button")]
        public void WhenIClickOnTheLogInButton()
        {
        }
        
        [Then(@"I see Authorization page")]
        public void ThenISeeAuthorizationPage()
        {
            bool checkAuthPage = AuthorizationSelectionSteps.CheckAuthorizationPage();

            Assert.IsTrue(checkAuthPage, "You didn't to the Authorization page");
        }
    }
}
