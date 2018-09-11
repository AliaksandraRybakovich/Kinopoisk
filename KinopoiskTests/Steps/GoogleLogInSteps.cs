using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class GoogleLogInSteps
    {
        static GoogleLogInPage googleLogInPage = new GoogleLogInPage();
        static WebDriverWait wait = new WebDriverWait(Browser.Browser.GetDriver(), TimeSpan.FromSeconds(15));

        public static bool CheckSocialLogInPage()
        {
            Browser.Browser.SwitchToWindow();            
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

            wait.Until(ExpectedConditions.ElementToBeClickable(googleLogInPage.passwordInputFields));
            googleLogInPage.passwordInputFields.Click();
            googleLogInPage.passwordInputFields.SendKeys(user.Password);
            googleLogInPage.buttonPassword.Click();

            return new HomePage();
        }

        public static HomePage SingIn(string login, string password)
        {
            Browser.Browser.SwitchToWindow();
            googleLogInPage.loginInputFields.Click();
            googleLogInPage.loginInputFields.SendKeys(login);
            googleLogInPage.buttonLogin.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(googleLogInPage.passwordInputFields));
            googleLogInPage.passwordInputFields.Click();
            googleLogInPage.passwordInputFields.SendKeys(password);
            googleLogInPage.buttonPassword.Click();

            return new HomePage();
        }
    }
}
