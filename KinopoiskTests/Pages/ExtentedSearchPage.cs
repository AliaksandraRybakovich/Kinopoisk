using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class ExtentedSearchPage: BasePage
    {
        private static readonly By uniqueElement = By.XPath("//*[@class = 'moviename-big']/span[1]");

        public ExtentedSearchPage() : base(uniqueElement, "Page of Extented Search")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.LinkText, Using = "//input[@class = 'text el_1']")]
        public IWebElement NameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='year']")]
        public IWebElement YearTextbox { get; set; }

        [FindsBy(How = How.LinkText, Using = "//*[@id='formSearchMain']/input[11]")]
        public IWebElement SearchButton { get; set; }
    }
}
