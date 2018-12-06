using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class LogSteps
    {
        static LogPage logPage = new LogPage();

        public static void LogIn()
        {
            logPage.Login.Click();
        }
    }
}
