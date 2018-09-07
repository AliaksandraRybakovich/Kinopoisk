using KinopoiskTests.ElementsWork;
using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class FilmCurrentSteps
    {
        static FilmCurrentPage currentfilmPage = new FilmCurrentPage();

        public static bool CheckFilm(ExtentedSearchInfo extSearch)
        {
            bool isAssertFilm = false;
            if ((currentfilmPage.NameOfFilms.Text == extSearch.NameOfFilms)&&
                (currentfilmPage.Year.Text == extSearch.Year))
            {
                isAssertFilm = true;
            }
            return isAssertFilm;
        }

        public static bool CheckFilm(string nemaOfFilm, string year)
        {
            bool isAssertFilm = false;
            if ((currentfilmPage.NameOfFilms.Text == nemaOfFilm) &&
                (currentfilmPage.Year.Text == year))
            {
                isAssertFilm = true;
            }
            return isAssertFilm;
        }
    }
}
