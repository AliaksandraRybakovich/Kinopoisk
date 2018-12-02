using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class FilmsPage: BasePage
    {
        private static readonly By uniqueElementFP = By.XPath("");

        public FilmsPage() : base(uniqueElementFP, "Page of Films")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.LinkText, Using = "Унесённые призраками")]
        public IWebElement LinkFilm { get; set; }
    }
}
