using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class YandexLogInPage: BasePage
    {
        private static readonly By uniqueElement = By.XPath("//*[contains(@class, 'logo_name')]");

        public YandexLogInPage():base(uniqueElement, "Google Log Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='passp - field - login']")]
        public IWebElement loginInputFields { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'passp-sign-in-button')]")]
        public IWebElement buttonLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@type ='password']")]
        public IWebElement passwordInputFields { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'passp-sign-in-button')]")]
        public IWebElement buttonPassword { get; set; }

    }
}
