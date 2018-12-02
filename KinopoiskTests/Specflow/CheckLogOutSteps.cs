using KinopoiskTests.Steps;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class CheckLogOutSteps
    {
        [Given(@"I use Kinopoisk as a user")]
        public void GivenIUseKinopoiskAsAUser()
        {
        }
        
        [When(@"I click on log out button")]
        public void WhenIClickOnLogOutButton()
        {
            HomeSteps.ClickOnLogOutForSpecflow();
        }
        
        [Then(@"i use Kinopoisk as a guest")]
        public void ThenIUseKinopoiskAsAGuest()
        {
            bool checkLogout = LogSteps.CheckLogOutPage();

            Assert.IsTrue(checkLogout, "You didn't log out from your account");
        }
    }
}
