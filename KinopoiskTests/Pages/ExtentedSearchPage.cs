using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;

namespace KinopoiskTests.Pages
{
    public class ExtentedSearchPage
    {
        public  BaseElemet checkSuccess = new BaseElemet(By.XPath("//*[@class = 'moviename-big']/span[1]"));
        public BaseElemet textboxName = new BaseElemet(By.XPath("//input[@class = 'text el_1']"));
        public BaseElemet textboxYear = new BaseElemet(By.XPath("//*[@id='year']"));
        public BaseElemet buttonSearch = new BaseElemet(By.XPath("//*[@id='formSearchMain']/input[11]"));
    }
}
