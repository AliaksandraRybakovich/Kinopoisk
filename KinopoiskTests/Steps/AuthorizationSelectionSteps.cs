using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class AuthorizationSelectionSteps
    {
        static AuthorizationSelectionPage authorizationSelectionPage = new AuthorizationSelectionPage();

        public static UniversalAuthorizationPage CLickOnHaveAccountButton()
        {
            authorizationSelectionPage.HaveAccount.Click();
            return new UniversalAuthorizationPage();
        }
    }
}
