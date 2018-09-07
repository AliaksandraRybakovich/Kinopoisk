using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public  class FilmCurrentPage
    {
        public BaseElemet NameOfFilms = new BaseElemet(By.XPath("//*[@id='headerFilm']/h1"));
        public BaseElemet Year = new BaseElemet(By.LinkText("2001"));

    }
}
