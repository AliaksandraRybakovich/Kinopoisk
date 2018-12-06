using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class AuthorizationSelectionPage:BasePage
    {
        private static readonly By uniqueElement = By.XPath("//*[@class ='auth__text']");

        public AuthorizationSelectionPage() : base(uniqueElement, "Page of option Choices")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }
        
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'type_cancel')]")]
        public IWebElement HaveAccount { get; set; }
    }
}
