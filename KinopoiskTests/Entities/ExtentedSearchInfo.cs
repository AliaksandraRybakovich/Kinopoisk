
namespace KinopoiskTests.Entities
{
    public class ExtentedSearchInfo
    {
        private readonly string _nameOfFilms;
        private readonly string _year;

        public string NameOfFilms { get { return _nameOfFilms; } }
        public string Year { get { return _year; } }

        public ExtentedSearchInfo() { }

        public ExtentedSearchInfo(string nameOfFilms, string year)
        {
            this._nameOfFilms = nameOfFilms;
            this._year = year;
        }
    }
}
