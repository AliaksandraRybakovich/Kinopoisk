using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;

namespace KinopoiskTests.Pages
{
    public class ExtentedSearchPage
    {
        public  BaseElement checkSuccess = new BaseElement(By.XPath("//*[@class = 'moviename-big']/span[1]"));
        public BaseElement textboxName = new BaseElement(By.XPath("//input[@class = 'text el_1']"));
        public BaseElement textboxYear = new BaseElement(By.XPath("//*[@id='year']"));
        public BaseElement buttonSearch = new BaseElement(By.XPath("//*[@id='formSearchMain']/input[11]"));
    }
}
