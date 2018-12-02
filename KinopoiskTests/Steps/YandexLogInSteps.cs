﻿using KinopoiskTests.Entities;
using KinopoiskTests.Pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Steps
{
    public class YandexLogInSteps
    {
        static YandexLogInPage yandexLogInPage = new YandexLogInPage();
      

        public static void SingIn(UserInfo user)
        {
            yandexLogInPage.loginInputFields.Click();
            yandexLogInPage.loginInputFields.SendKeys(user.Login);
            yandexLogInPage.buttonLogin.Click();

            yandexLogInPage.passwordInputFields.Click();
            yandexLogInPage.passwordInputFields.SendKeys(user.Password);
            yandexLogInPage.buttonPassword.Click();
        }

        public static void SingIn(string login, string password)
        {
            Browser.Browser.SwitchToWindow();
            yandexLogInPage.loginInputFields.Click();
            yandexLogInPage.loginInputFields.SendKeys(login);
            yandexLogInPage.buttonLogin.Click();
            yandexLogInPage.passwordInputFields.Click();
            yandexLogInPage.passwordInputFields.SendKeys(password);
            yandexLogInPage.buttonPassword.Click();
        }
    }
}
