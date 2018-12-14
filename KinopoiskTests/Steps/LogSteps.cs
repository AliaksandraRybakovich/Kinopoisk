using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class LogSteps
    {
        static LogPage logPage = new LogPage();

        public static AuthorizationSelectionPage LogIn()
        {
            logPage.Login.Click();
            return new AuthorizationSelectionPage();
        }
    }
}
