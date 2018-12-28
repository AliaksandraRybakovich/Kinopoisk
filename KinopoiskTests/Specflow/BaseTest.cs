using KinopoiskTests.Browser;
using TechTalk.SpecFlow;

namespace KinopoiskTests.Specflow
{
    [Binding]
    public class BaseTest
    {
        protected static Browser.Browser browser;

        [BeforeScenario]
        public static void BeforeScenarioBrowser()
        {
            browser = Browser.Browser.GetInstance();
            Browser.Browser.NavigateTo(Configuration.Url);
        }

        [AfterScenario]
        public static void AfterScenarioBrowser()
        {
            Browser.Browser.Quit();            
        }        
    }
}
