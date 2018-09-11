using KinopoiskTests.Steps;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class CheckLoginToKinopoiskSteps
    {
        [Given(@"I have the page with google log in")]
        public void GivenIHaveThePageWithGoogleLogIn()
        {
        }
        
        [When(@"I enter (.*) and (.*) in google account")]
        public void WhenIEnterAlexandra_TestatestGmail_ComAndAlexRybka_TestInGoogleAccount(string login, string password)
        {
            Entities.UserInfo user = new Entities.UserInfo(login, password);
            GoogleLogInSteps.SingIn(user.Login,user.Password);
        }
        
        [Then(@"i use Kinopoisk as a user")]
        public void ThenIUseKinopoiskAsAUser()
        {
            bool checkLogInToKinopoisk = HomeSteps.CheckLogo();

            Assert.IsTrue(checkLogInToKinopoisk, "You didn't sing in to Kinopoisk");
        }
    }
}
