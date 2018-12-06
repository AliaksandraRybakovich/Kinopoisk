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
            LogSteps.LogIn();
            AuthorizationSelectionSteps.CLickOnHaveAccountButton();
            UniversalAuthorizationSteps.ClickOnYandexButton();
            YandexLogInSteps.SingInYandexAccount(user);
            
            //assert check the user id
        }

        [Test]
        public void TestLogOut()
        {
            //log in to kinopoisk throw id user

            HomeSteps.ClickOnLogOutButton();

            //assert log page
        }
    }
    
    [TestFixture]
    public class Test2 : BaseTest
    {
        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForExtendedSearch")]
        public void TestExtentedSearch(ExtentedSearchInfo searchData)
        {
            //log in to kinopoisk throw id user

            HomeSteps.ClickOnExtentedSearchButton();
            ExtentedSearchSteps.EnterDataForExtSearch(searchData);
            SearchResultsSteps.ClickOnMovieRerference();

           bool isAssert = FilmInfoSteps.VerificationFilmInfo(searchData);

            Assert.IsTrue(isAssert);
        }
    }
}
