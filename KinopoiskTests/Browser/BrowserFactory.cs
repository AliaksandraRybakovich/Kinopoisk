using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace KinopoiskTests.Browser
{
    public class BrowserFactory
    {       
        public static IWebDriver GetDriver(string browser)
        {
            IWebDriver driver = null;

            switch (browser)
            {
                case "Chrome":               
                    ChromeOptions options = new ChromeOptions();
                    var service = ChromeDriverService.CreateDefaultService();
                    options.AddArguments("--start-maximized", "--disable-infobars");
                    driver = new ChromeDriver(service, options,TimeSpan.FromSeconds(15));
                    break;

                case "FireFox":
                    FirefoxOptions optionsF = new FirefoxOptions();
                    optionsF.AddArguments("--start-maximized", "--disable-infobars");
                    driver = new FirefoxDriver(optionsF);
                    driver.Manage().Window.Maximize();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();                   
                    driver.Manage().Window.Maximize();
                    break;

            }
            return driver;
        }
    }
}
