using KinopoiskTests.Entities;
using KinopoiskTests.Steps;
using NUnit.Framework;

namespace KinopoiskTests.Tests
{
    [TestFixture]
    [Category("Log In/Out")]
    public class Test : BaseTest
    {
        [Test, Order(1)]
        public void CheckAuthorizationPage()
        {
            LogSteps.LogIn();

            bool checkAuthPage = AuthorizationSteps.CheckAuthorizationPage();

            Assert.IsTrue(checkAuthPage, "You didn't to the Authorization page");
        }

        [Test, Order(2)]
        public void CheckSocialExtenteSocialPanel()
        {
            AuthorizationSteps.ClickOnButtonExtenteSocialPanel();

            bool checkSocialLogin = AuthorizationSteps.CheckExtenteSocialPanel();
            
            Assert.IsTrue(checkSocialLogin, "You didn't open extente social panel");
        }

        [Test, Order(3), TestCaseSource(typeof(GetDataFromCsv), "ReadCsvForLogInUser")]
        public void CheckGoToGoogleLogIn(UserInfo user)
        {
            AuthorizationSteps.ClickOnButtonGoogle();

            bool checkGoToGoogleLogIn = GoogleLogInSteps.CheckSocialLogInPage();

            Assert.IsTrue(checkGoToGoogleLogIn, "You didn't go to page google Sing In");
        }

        [Test, Order(4), TestCaseSource(typeof(GetDataFromCsv), "ReadCsvForLogInUser")]
        public void CheckLogInToKinopoisk(UserInfo user)
        {
            GoogleLogInSteps.SingIn(user);

            bool checkLogInToKinopoisk = HomeSteps.CheckLogo();

            Assert.IsTrue(checkLogInToKinopoisk, "You didn't sing in to Kinopoisk");
        }

        [Test, Order(5), TestCaseSource(typeof(GetDataFromCsv), "ReadCsvForDropdown")]
        public void CheckLogOut(FieldForDropDown dropdownText)
        {
            HomeSteps.ClickOnLogOut(dropdownText);

            bool checkLogout = LogSteps.GeckLogOutPage();

            Assert.IsTrue(checkLogout, "You didn't log out from your account");
        }
    }
    [TestFixture]
    [Category("Extented Search")]
    public class Test2 : BaseTest
    {
        [Test, Order(6)]
        public void CheckExtentedPage()
        {
            HomeSteps.ClickOnButtonExtSearch();

            bool checkSearchPage = ExtentedSearchSteps.CheckExtentedSearch();

            Assert.IsTrue(checkSearchPage, "You didn't to the extented search page");
        }

        [Test, Order(7), TestCaseSource(typeof(GetDataFromCsv), "ReadCsvForExtendedSearch")]
        public void CheckExtentedSeach(ExtentedSearchInfo searchData)
        {
            ExtentedSearchSteps.EnterDataForExtSearch(searchData);
            FilmsSteps.GoTOLinkFilm();

            bool checkSearchFilm = FilmCurrentSteps.CheckFilm(searchData);

            Assert.IsTrue(checkSearchFilm, "This film didn't coincide with given parameter");
        }
    }
}
