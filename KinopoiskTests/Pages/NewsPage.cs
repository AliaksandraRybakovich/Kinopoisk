using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace KinopoiskTests.Pages
{
    public class NewsPage:BasePage
    {
        private static readonly By uniqueElement = By.XPath("");

        public NewsPage() : base(uniqueElement, "News Page")
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }

        [FindsBy(How =How.XPath, Using = "//tr/td/a[@class = 'ui-state-default']")]
        public List<IWebElement> Day { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div/span[@class = 'article__more_text'][1]")]
        public List<IWebElement> NewsData { get; set; }
    }
}
