using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace KinopoiskTests.Pages
{
    public abstract class BasePage
    {
        protected By _titleLocator;
        protected string _title;
        
        protected BasePage(By titleLocator, string title)
        {
            _titleLocator = titleLocator;
            _title = title;
            AssertIsOpen();
        }

        public void AssertIsOpen()
        {
            //string id = String.Empty;
            //string yandexId = String.Empty;
            //try
            //{
            //    WebDriverWait wait = new WebDriverWait(Browser.Browser.GetDriver(), TimeSpan.FromSeconds(10));
            //    Browser.Browser.SwitchToWindow(_title, out id, out yandexId);
            //    wait.Until(ExpectedConditions.ElementIsVisible(_titleLocator));
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception($"Message: {ex.Message} \nStackTrace: {ex.StackTrace} \nLocator {_titleLocator} \nTitle: {_title}\nId {id}\nYandexId{yandexId}");
            //}

            WebDriverWait wait = new WebDriverWait(Browser.Browser.GetDriver(), TimeSpan.FromSeconds(10));
            Browser.Browser.SwitchToWindow(_title);
            wait.Until(ExpectedConditions.ElementIsVisible(_titleLocator));
        }
    }
}
