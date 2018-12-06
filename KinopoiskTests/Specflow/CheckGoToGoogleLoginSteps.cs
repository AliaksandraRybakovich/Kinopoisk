using KinopoiskTests.Steps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class CheckGoToGoogleLoginSteps
    {
        [Given(@"I have logIn to account throw google")]
        public void GivenIHaveLogInToAccountThrowGoogle()
        {
        }
        
        [When(@"I click on button google badges")]
        public void WhenIClickOnButtonGoogleBadges()
        {
            AuthorizationSelectionSteps.ClickOnButtonGoogle();
        }
        
        [Then(@"I see a page with input field for google")]
        public void ThenISeeAPageWithInputFieldForGoogle()
        {
            bool checkGoToGoogleLogIn = YandexLogInSteps.CheckSocialLogInPage();

            Assert.IsTrue(checkGoToGoogleLogIn, "You didn't go to page google Sing In");
        }
    }
}
