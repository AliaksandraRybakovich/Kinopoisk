using System;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using KinopoiskTests.ElementsWork;

namespace KinopoiskTests.Browser
{
   public class Browser
    {
        private static IWebDriver _driver;
        private  static Browser _instance;
        public static BrowserFactory.BrowserType _currentBrowser;
        
        
        private Browser()
        {
            _driver = BrowserFactory.GetDriver(_currentBrowser);
        }

        public static Browser GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Browser();
            }
            return _instance;
        }

        public static IWebDriver GetDriver()
        {
            return _driver;
        }

        public static void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }       

        public static void Quit()
        {
            _driver.Quit();
            _instance = null;
            _driver = null;
        }
    }
}
