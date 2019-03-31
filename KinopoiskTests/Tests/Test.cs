using KinopoiskTests.Entities;
using KinopoiskTests.Steps;
using NUnit.Framework;
using OpenQA.Selenium;

namespace KinopoiskTests.Tests
{
    [TestFixture("https://www.kinopoisk.ru/")]
    public class Test : BaseTest
    {
        public Test(string url) : base(url) { }

        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForLogInUser")]
        public void TestLogin(UserInfo user)
        {
            Browser.Browser.NavigateTo(_url);
            new HomeSteps();  

            HomeSteps.LogIn();

            YandexLogInSteps.SingInYandexAccount(user);
        }

        [Test]
        public void TestLogOut()
        {
            Browser.Browser.NavigateTo(_url);
            Browser.Browser.CookieForAuthorization();

            new HomeSteps();

            HomeSteps.ClickOnLogOutButton();
        }

        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForExtendedSearch")]
        public void TestExtentedSearch(ExtentedSearchInfo searchData)
        {
            Browser.Browser.NavigateTo(_url);
            new HomeSteps();

            HomeSteps.ClickOnExtentedSearchButton();
            ExtentedSearchSteps.EnterDataForExtSearch(searchData);
            SearchResultsSteps.ClickOnMovieRerference();

            bool isAssert = FilmInfoSteps.VerificationFilmInfo(searchData);

            Assert.IsTrue(isAssert);
        }
    }

    [TestFixture("https://www.kinopoisk.ru/news/")]
    public class Test2 : BaseTest
    {
        public Test2(string url) : base(url) { }

        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForDataNews")]
        public void TestDataNews(DataNewsInfo dataNews)
        {
            Browser.Browser.NavigateTo(_url);
            new NewsSteps();
            NewsSteps.ClickOnData(dataNews);

            bool isAssert = NewsSteps.AssertCollectionNews(dataNews);

            Assert.IsTrue(isAssert);
        }
    }
}
