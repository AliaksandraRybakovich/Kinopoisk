using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class SearchResultsPage: BasePage
    {
        private static readonly By uniqueElement = By.XPath("//*[@class = 'search_results']");

        public SearchResultsPage() : base(uniqueElement, "Page of Films")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.LinkText, Using = "Унесённые призраками")]
        public IWebElement LinkFilm { get; set; }
    }
}
