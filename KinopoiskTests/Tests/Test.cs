using KinopoiskTests.Entities;
using KinopoiskTests.Steps;
using NUnit.Framework;

namespace KinopoiskTests.Tests
{
    [TestFixture]
    public class Test : BaseTest
    {       
        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForLogInUser")]
        public void TestLogin(UserInfo user)
        {
            new LogSteps();
            LogSteps.LogIn();
            AuthorizationSelectionSteps.CLickOnHaveAccountButton();
            UniversalAuthorizationSteps.ClickOnYandexButton();

            YandexLogInSteps.SingInYandexAccount(user);
        }

        [Test]
        public void TestLogOut()
        {
            Browser.Browser.CookieForAuthorization();

            HomeSteps.ClickOnLogOutButton();            
        }
    }
    
    [TestFixture]
    public class Test2 : BaseTest
    {
        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForExtendedSearch")]
        public void TestExtentedSearch(ExtentedSearchInfo searchData)
        {
            new HomeSteps();

            HomeSteps.ClickOnExtentedSearchButton();
            ExtentedSearchSteps.EnterDataForExtSearch(searchData);
            SearchResultsSteps.ClickOnMovieRerference();

            bool isAssert = FilmInfoSteps.VerificationFilmInfo(searchData);

            Assert.IsTrue(isAssert);
        }
    }
}
