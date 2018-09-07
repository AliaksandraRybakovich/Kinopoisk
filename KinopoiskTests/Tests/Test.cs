using KinopoiskTests.Entities;
using KinopoiskTests.Steps;
using NUnit.Framework;

namespace KinopoiskTests.Tests
{
    [TestFixture]
    public class Test : BaseTest
    {
        [Test]
        public void CheckExtentedPage()
        {
            HomeSteps.ClickOnButtonExtSearch();

            bool checkSearchPage = ExtentedSearchSteps.CheckExtentedSearch();

            Assert.IsTrue(checkSearchPage, "You didn't to the extented search page");
        }

        [Test,  TestCaseSource(typeof(GetDataFromCsv), "ReadCsvForExtendedSearch")]
        public void CheckExtentedSeach(ExtentedSearchInfo searchData)
        {
            ExtentedSearchSteps.EnterDataForExtSearch(searchData);
            FilmsSteps.GoTOLinkFilm();

            bool checkSearchFilm = FilmCurrentSteps.CheckFilm(searchData);

            Assert.IsTrue(checkSearchFilm, "This film didn't coincide with given parameter");
        }
        
    }
}
