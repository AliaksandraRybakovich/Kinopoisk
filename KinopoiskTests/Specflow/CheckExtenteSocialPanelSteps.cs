using KinopoiskTests.Steps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class CheckExtenteSocialPanelSteps
    {
        [Given(@"I have not all badges on social panel")]
        public void GivenIHaveNotAllBadgesOnSocialPanel()
        {
        }
        
        [When(@"I click on button more")]
        public void WhenIClickOnButtonMore()
        {
            AuthorizationSteps.ClickOnButtonExtenteSocialPanel();
        }
        
        [Then(@"I see the other social badges")]
        public void ThenISeeTheOtherSocialBadges()
        {
            bool checkSocialLogin = AuthorizationSteps.CheckExtenteSocialPanel();

            Assert.IsTrue(checkSocialLogin, "You didn't open extente social panel");
        }
    }
}
