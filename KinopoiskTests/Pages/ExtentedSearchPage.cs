using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class ExtentedSearchPage: BasePage
    {
        private static readonly By uniqueElementESP = By.XPath("");

        public ExtentedSearchPage() : base(uniqueElementESP, "Page of Extented Search")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'moviename-big']/span[1]")]
        public IWebElement CheckSuccess { get; set; }

        [FindsBy(How = How.LinkText, Using = "//input[@class = 'text el_1']")]
        public IWebElement TextboxName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='year']")]
        public IWebElement TextboxYear { get; set; }

        [FindsBy(How = How.LinkText, Using = "//*[@id='formSearchMain']/input[11]")]
        public IWebElement ButtonSearch { get; set; }
    }
}
