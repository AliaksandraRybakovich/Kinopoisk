using KinopoiskTests.Browser;
using NUnit.Framework;
using System.Diagnostics;

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

        [OneTimeTearDown]
        public void TearDownKillAllProccesBrowser()
        {
            var processes = Process.GetProcessesByName("chromedriver");
            foreach (var process in processes)
            {
                process.Kill();
            }
        }
    }
}
