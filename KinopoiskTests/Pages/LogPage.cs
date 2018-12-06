using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KinopoiskTests.Pages
{
    public class LogPage: BasePage
    {
        private static readonly By uniqueElement = By.XPath("//*[@class ='kp2 - authapi - overlay']");

        public LogPage() : base(uniqueElement, "Log Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'login')]")]
        public IWebElement Login { get; set; }
    }
}
