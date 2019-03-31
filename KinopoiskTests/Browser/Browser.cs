using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace KinopoiskTests.Browser
{
    public class Browser
    {
        private static IWebDriver _driver;
        private static Browser _instance;
        private static readonly object locker = new object();
        public static BrowserFactory.BrowserType _currentBrowser;
        private static Actions action;
        private static Dictionary<string, string> windows;
        private static Cookie cookie;

        private Browser()
        {
            _driver = BrowserFactory.GetDriver(_currentBrowser);
            action = new Actions(_driver);
            windows = new Dictionary<string, string>();
        }

        public static Browser GetInstance()
        {
            lock (locker)
            {
                if (_instance == null)
                {
                    _instance = new Browser();
                }
                return _instance;
            }
        }

        public static IWebDriver GetDriver()
        {
            return _driver;
        }

        public static void MaximizeBrowser()
        {
            _driver.Manage().Window.Maximize();
        }

        public static void NavigateTo(string Url)
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public static void DeleteAllCookies()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
        }
                
        public static void CookieForAuthorization()
        {
            _driver.Manage().Cookies.AddCookie(new Cookie("Session_id", Configuration.SessionID));
            _driver.Navigate().Refresh();
        }
               
        public static void SwitchToWindow(string title)
        {
            if (_driver.WindowHandles != null)
            {
                if (!windows.ContainsKey(title))
                {
                    windows.Add(title, _driver.WindowHandles.LastOrDefault());
                }
            }
            _driver.SwitchTo().Window(windows[title]);
        }

        public static void SwitchToFrame(IWebElement nameFrame)
        {
            _driver.SwitchTo().Frame(nameFrame);
        }

        public static void MoveMouseAndClick(IWebElement nameElement)
        {
            //везде заменить TimeSpan.FromSeconds(10) на одну переменую откуда-нибудь

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(nameElement));
            action.MoveToElement(nameElement).Click();
        }

        public static void Quit()
        {
            _driver.Quit();
            if (_currentBrowser == BrowserFactory.BrowserType.Chrome)
            {
                var processes = Process.GetProcessesByName("chromedriver");
                foreach (var process in processes)
                {
                    process.Kill();
                }
            }
            _instance = null;
            _driver = null;
        }
    }
}
