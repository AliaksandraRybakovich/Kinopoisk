using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

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
                    options.AddArgument("--start-maximized");
                    driver = new ChromeDriver(options);
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
