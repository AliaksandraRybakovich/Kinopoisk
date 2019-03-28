using NUnit.Framework;

namespace KinopoiskTests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected static Browser.Browser browser;
        protected string _url;

        public BaseTest (string url)
        {
            _url = url;
        }

        [OneTimeSetUp]
        public void SetUpBrowser()
        {
            browser = Browser.Browser.GetInstance();
        }

        [OneTimeTearDown]
        public void TearDownBrowser()
        {
            Browser.Browser.DeleteAllCookies();
            Browser.Browser.Quit();
        }
    }
}
