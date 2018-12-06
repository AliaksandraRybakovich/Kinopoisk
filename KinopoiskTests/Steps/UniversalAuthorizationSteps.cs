using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class UniversalAuthorizationSteps
    {
        static UniversalAuthorizationPage universalAuthorizationPage = new UniversalAuthorizationPage();

        public static void ClickOnYandexButton()
        {
            universalAuthorizationPage.yandexButton.Click();
        }
    }
}
