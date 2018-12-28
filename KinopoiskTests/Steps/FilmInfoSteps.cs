using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class FilmInfoSteps
    {
        static FilmInfoPage filmInfoPage = new FilmInfoPage();

        public static bool VerificationFilmInfo(ExtentedSearchInfo dataOfSearch)
        {
            bool isAssert = false;
            if ((filmInfoPage.NameOfFilms.Text == dataOfSearch.NameOfFilm) &&
                (filmInfoPage.FilmYear.Text == dataOfSearch.YearFilm))
            {
                isAssert = true;
            }
            return isAssert;
        }

        public static bool VerificationFilmInfo(string nameOfFilm, string yearFilm)
        {
            bool isAssert = false;
            if ((filmInfoPage.NameOfFilms.Text == nameOfFilm) &&
                (filmInfoPage.FilmYear.Text == yearFilm))
            {
                isAssert = true;
            }
            return isAssert;
        }
    }
}
