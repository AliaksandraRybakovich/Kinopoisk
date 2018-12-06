using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace KinopoiskTests.Browser
{
    public class Browser
    {
        private static IWebDriver _driver;
        private static Browser _instance;
        private static readonly object locker = new object();
        public static BrowserFactory.BrowserType _currentBrowser;

        static Boolean _readyStateComplete = false;

        static WebDriverWait _wait;

        private Browser()
        {
            _driver = BrowserFactory.GetDriver(_currentBrowser);
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

        public static void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
        
        //public static bool CheckStateLoading()
        //{
        //    while (!_readyStateComplete)
        //    {
        //        IJavaScriptExecutor executor = (IJavaScriptExecutor)_driver;
        //        executor.ExecuteScript("window.scrollTo(0, document.body.offsetHeight)");
        //        _readyStateComplete = ((String)executor.ExecuteScript("return document.readyState")).Equals("complete");
        //    }
        //    return _readyStateComplete = true;
        //}

        public static void SwitchToWindow()
        {
            string windowHandle = string.Empty;
            ReadOnlyCollection<string> windowHandles = _driver.WindowHandles;
            foreach (string handle in windowHandles)
            {
                if (handle != _driver.CurrentWindowHandle)
                {
                    windowHandle = handle;
                    break;
                }
            }
            _driver.SwitchTo().Window(windowHandle);
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
