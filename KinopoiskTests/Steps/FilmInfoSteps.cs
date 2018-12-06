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
            if ((filmInfoPage.NameOfFilms.Text == dataOfSearch.NameOfFilms) &&
                (filmInfoPage.FilmYear.Text == dataOfSearch.YearFilm))
            {
                isAssert = true;
            }
            return isAssert;
        }
    }
}
