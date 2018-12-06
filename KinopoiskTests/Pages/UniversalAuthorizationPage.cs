using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class UniversalAuthorizationPage: BasePage
    {
        private static readonly By uniqueElement = By.XPath("//iframe[@name= 'kp2-authapi-iframe']");

        public UniversalAuthorizationPage():base(uniqueElement, "Authorization Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }
        
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'code_gg')]")]
        public IWebElement yandexButton { get; set; }
    }
}
