using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;

namespace KinopoiskTests.Pages
{
    public  class FilmCurrentPage
    {
        public BaseElement NameOfFilms = new BaseElement(By.XPath("//*[@id='headerFilm']/h1"));
        public BaseElement Year = new BaseElement(By.LinkText("2001"));

    }
}
