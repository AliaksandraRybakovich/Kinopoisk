using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class GoogleLogInPage
    {
        public GoogleLogInPage()
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@type ='email']")]
        public IWebElement loginInputFields { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id= 'identifierNext']")]
        public IWebElement buttonLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@type ='password']")]
        public IWebElement passwordInputFields { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id= 'passwordNext']")]
        public IWebElement buttonPassword { get; set; }

    }
}
