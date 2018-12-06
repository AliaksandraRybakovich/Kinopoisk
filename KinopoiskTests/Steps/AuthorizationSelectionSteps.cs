using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class AuthorizationSelectionSteps
    {
        static AuthorizationSelectionPage authorizationSelectionPage = new AuthorizationSelectionPage();

        public static void CLickOnHaveAccountButton()
        {
            authorizationSelectionPage.HaveAccount.Click();
        }
    }
}
