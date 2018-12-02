using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace KinopoiskTests.Pages
{
    public class HomePage: BasePage
    {
        private static readonly By uniqueElementHP = By.XPath("//*[@class='header']");

        public HomePage(): base(uniqueElementHP, "Home Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }
                
        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'avatar-hover')]")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'advanced-search-button')]")]
        public IWebElement ButtonExtendedSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'dropdown_visible')]")]
        public IWebElement Dropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@href= '/logout/']")]
        public IWebElement LogOut { get; set; }

    }
}
