using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class LogSteps
    {
        static LogPage logPage = new LogPage();

        public static AuthorizationPage LogIn()
        {
            logPage.login.Click();
            return new AuthorizationPage();
        }

        public static bool GeckLogOutPage()
        {
            Browser.Browser.SwitchToWindow();
            Browser.Browser.CheckStateLoading();
            bool isAssertLogout = false;
            if (logPage.login.Displayed)
            {
                isAssertLogout = true;
            }
            return isAssertLogout;
        }
    }
}
