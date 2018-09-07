using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using KinopoiskTests.Browser;

namespace KinopoiskTests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected static Browser.Browser browser;

        [OneTimeSetUp]
        public void SetUpBrowser()
        {
            browser = Browser.Browser.GetInstance();
            Browser.Browser.NavigateTo(Configuration.Url);
        }

        [OneTimeTearDown]
        public void TearDownBrowser()
        {
            Browser.Browser.Quit();
        }
    }
}
