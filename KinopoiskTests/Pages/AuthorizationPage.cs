using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class AuthorizationPage: BasePage
    {
        private static readonly By uniqueElementAP = By.XPath("//a[contains(@class,'help - link')]");

        public AuthorizationPage():base(uniqueElementAP, "Authorization Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }
        
        [FindsBy(How = How.XPath, Using = "//iframe[@name= 'kp2-authapi-iframe']")]
        public IWebElement socialPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'social-auth__more')]")]
        public IWebElement extenteSocialPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'code_gg')]")]
        public IWebElement yandexButton { get; set; }
    }
}
