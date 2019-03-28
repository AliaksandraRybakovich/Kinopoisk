using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class YandexLogInPage: BasePage
    {
        private static readonly By uniqueElement = By.XPath("//div[@class = 'passp-auth']");

        public YandexLogInPage():base(uniqueElement, "Yandex Log Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input')]//input[@name = 'login']")]
        public IWebElement loginInputFields { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type= 'submit'][1]")]
        public IWebElement buttonLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input')]//input[@name = 'passwd']")]
        public IWebElement passwordInputFields { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type= 'submit']")]
        public IWebElement buttonPassword { get; set; }
    }
}
