using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class GoogleLogInSteps
    {
        static GoogleLogInPage googleLogInPage = new GoogleLogInPage();

        public static bool CheckSocialLogInPage()
        {
            Browser.Browser.SwitchToWindow();
            Browser.Browser.CheckStateLoading();
            bool isAssertGoogleLoGin = false;
            if (googleLogInPage.loginInputFields.Displayed)
            {
                isAssertGoogleLoGin = true;
            }
            return isAssertGoogleLoGin;
        }

        public static HomePage SingIn(UserInfo user)
        {
            googleLogInPage.loginInputFields.Click();
            googleLogInPage.loginInputFields.SendKeys(user.Login);
            googleLogInPage.buttonLogin.Click();
                        
            googleLogInPage.passwordInputFields.Click();
            googleLogInPage.passwordInputFields.SendKeys(user.Password);
            googleLogInPage.buttonPassword.Click();

            return new HomePage();
        }
    }
}
