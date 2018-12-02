using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public  class FilmCurrentPage: BasePage
    {
        private static readonly By uniqueElementFCP = By.XPath("");

        public FilmCurrentPage() : base(uniqueElementFCP, "Page of Current Films")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='headerFilm']/h1")]
        public IWebElement NameOfFilms { get; set; }

        [FindsBy(How = How.LinkText, Using = "2001")]
        public IWebElement Year { get; set; }       

    }
}
