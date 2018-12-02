using KinopoiskTests.Entities;
using KinopoiskTests.Steps;
using NUnit.Framework;

namespace KinopoiskTests.Tests
{
    [TestFixture]
    public class Test : BaseTest
    {       
        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForLogInUser")]
        public void CheckLogInToKinopoisk(UserInfo user)
        {
            YandexLogInSteps.SingIn(user);

           
        }

        [Test]
        public void CheckLogOut()
        {
            HomeSteps.ClickOnLogOut();
        }
    }

    [TestFixture]
    public class Test2 : BaseTest
    {
        [Test, TestCaseSource(typeof(CsvDataReader), "ReadCsvForExtendedSearch")]
        public void CheckExtentedSeach(ExtentedSearchInfo searchData)
        {
            ExtentedSearchSteps.EnterDataForExtSearch(searchData);
        }
    }
}
