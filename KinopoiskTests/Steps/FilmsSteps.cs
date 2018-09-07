using KinopoiskTests.Entities;
using KinopoiskTests.Pages;


namespace KinopoiskTests.Steps
{
   public class FilmsSteps
    {
        static FilmsPage filmsPage = new FilmsPage();
        public static FilmCurrentPage GoTOLinkFilm()
        {
            if (filmsPage.linkFilm.Displayed)
            {
                filmsPage.linkFilm.Click();
            }
            return new FilmCurrentPage();
        }
    }
}
