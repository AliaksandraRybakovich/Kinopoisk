using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class UniversalAuthorizationSteps
    {
        static UniversalAuthorizationPage universalAuthorizationPage = new UniversalAuthorizationPage();

        public static YandexLogInPage ClickOnYandexButton()
        {
            universalAuthorizationPage.yandexButton.Click();
            return new YandexLogInPage();
        }
    }
}
