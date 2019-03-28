using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public  class FilmInfoPage: BasePage
    {
        private static readonly By uniqueElement = By.Id("headerFilm");

        public FilmInfoPage() : base(uniqueElement, "Page of Current Films")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='headerFilm']/h1")]
        public IWebElement NameOfFilms { get; set; }

        [FindsBy(How = How.LinkText, Using = "2001")]
        public IWebElement FilmYear { get; set; }       

    }
}
