using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KinopoiskTests.Steps
{
    public class YandexLogInSteps
    {
        static YandexLogInPage yandexLogInPage = new YandexLogInPage();

        public static HomePage SingInYandexAccount(UserInfo user)
        {
            Browser.Browser.MoveMouseAndClick(yandexLogInPage.loginInputFields);
            yandexLogInPage.loginInputFields.SendKeys(user.Login);
            yandexLogInPage.buttonLogin.Click();

            Browser.Browser.MoveMouseAndClick(yandexLogInPage.passwordInputFields);
            yandexLogInPage.passwordInputFields.SendKeys(user.Password);
            yandexLogInPage.buttonPassword.Click();

            try
            {
                yandexLogInPage.buttonNotNow.Click();
            }
            catch (NoSuchElementException e)
            {
                return new HomePage();
            }

            return new HomePage();
        }

        //public static void SingInYandexAccount(string login, string password)
        //{
        //    Browser.Browser.SwitchToWindow();
        //    yandexLogInPage.loginInputFields.Click();
        //    yandexLogInPage.loginInputFields.SendKeys(login);
        //    yandexLogInPage.buttonLogin.Click();
        //    yandexLogInPage.passwordInputFields.Click();
        //    yandexLogInPage.passwordInputFields.SendKeys(password);
        //    yandexLogInPage.buttonPassword.Click();
        //}
    }
}
