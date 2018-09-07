using KinopoiskTests.Browser;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class TestBase
    {
        protected static Browser.Browser browser;

        [BeforeScenario]
        public static void SetUpBrowser()
        {
            browser = Browser.Browser.GetInstance();
            Browser.Browser.NavigateTo(Configuration.Url);
        }

        [AfterScenario]
        public static void TearDownBrowser()
        {
            Browser.Browser.Quit();
        }

    }
}