using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace KinopoiskTests.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Browser.Browser.GetDriver(), this);
        }        

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'advanced-search-button')]")]       
        public  IWebElement ButtonExtendedSearch { get; set; }
        
    }
}
