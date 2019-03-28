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

            HomeSteps.ChooseLogIn();

            YandexLogInSteps.SingInYandexAccount(user);
        }

        [Test]
        public void TestLogOut()
        {
           
            Browser.Browser.NavigateTo(_url);
            var cookie = new Cookie("Session_id", "3%3A1552844385.5.0.1552844385564%3AAQAAfw%3AE5.1%7C1110000015690266.-1.0%7C30%3A179248.996803.v5ZYiWYOwLVpzVCmym4KgjFpvUg");
            Browser.Browser.GetDriver().Manage().Cookies.AddCookie(cookie);
            Browser.Browser.GetDriver().Navigate().Refresh();

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
