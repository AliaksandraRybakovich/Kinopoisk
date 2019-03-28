using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class HomePage: BasePage
    {
        private static readonly By uniqueElement = By.XPath("//div[contains(@class, 'user-container')]");

        public HomePage(): base(uniqueElement, "Home Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'login')]")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.XPath, Using = "//iframe[contains(@class, 'authapi')]")]
        public IWebElement IFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'type_cancel')]")]
        public IWebElement HaveAccount { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'code_ya')]")]
        public IWebElement YandexButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'avatar-hover')]")]
        public IWebElement Logo { get; set; }               

        [FindsBy(How = How.XPath, Using = "//*[@href= '/logout/']")]
        public IWebElement LogOut { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'advanced-search-button')]")]
        public IWebElement ExtentedSearchButton { get; set; }
    }
}
