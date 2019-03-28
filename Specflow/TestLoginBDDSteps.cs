using KinopoiskTests.Steps;
using System;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class TestLoginBDDSteps
    {
        [Given(@"I follow to the log in form")]
        public void GivenIFollowToTheLogInForm()
        {
           // new LogSteps();
            //LogSteps.LogIn();
        }
        
        [Given(@"I click on button \*Have Account\*")]
        public void GivenIClickOnButtonHaveAccount()
        {
            //AuthorizationSelectionSteps.CLickOnHaveAccountButton();
        }
        
        [Given(@"I click on button \*Yandex social network\*")]
        public void GivenIClickOnButtonYandexSocialNetwork()
        {
            //UniversalAuthorizationSteps.ClickOnYandexButton();
        }
        
        [When(@"I have entered (.*) and (.*) on Yandex form")]
        public void WhenIHaveEnteredAlexandra_TestatestAndAlexRybka_TestOnYandexForm(string login, string password)
        {
           // YandexLogInSteps.SingInYandexAccount(login, password);
        }        
    }
}
