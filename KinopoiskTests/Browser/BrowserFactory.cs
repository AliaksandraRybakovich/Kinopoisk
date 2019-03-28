using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;

namespace KinopoiskTests.Browser
{
    public class BrowserFactory
    {
        public enum BrowserType
        {
            Chrome,
            FireFox,
            IE
        }

        public static IWebDriver GetDriver(BrowserType type)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case BrowserType.Chrome:               
                    ChromeOptions options = new ChromeOptions();
                    var service = ChromeDriverService.CreateDefaultService();
                    options.AddArguments("--start-maximized", "--disable-infobars");
                    driver = new ChromeDriver(service, options,TimeSpan.FromSeconds(15));
                    break;

                case BrowserType.FireFox:
                    driver = new FirefoxDriver();
                    break;

                case BrowserType.IE:
                    driver = new InternetExplorerDriver();
                    break;

            }
            return driver;
        }
    }
}
