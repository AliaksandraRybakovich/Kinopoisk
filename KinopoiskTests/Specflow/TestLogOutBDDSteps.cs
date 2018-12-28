using KinopoiskTests.Steps;
using System;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class TestLogOutBDDSteps
    {
        [Given(@"I follow to the Home Page as a registered user")]
        public void GivenIFollowToTheHomePageAsARegisteredUser()
        {
            Browser.Browser.CookieForAuthorization();
        }               
        
        [When(@"I click on button \*Exit\*")]
        public void WhenIClickOnButtonExit()
        {
            HomeSteps.ClickOnLogOutButton();
        }        
    }
}
