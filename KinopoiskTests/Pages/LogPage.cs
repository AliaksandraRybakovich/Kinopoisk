using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;

namespace KinopoiskTests.Pages
{
    public class LogPage
    {
        public BaseElement login = new BaseElement(By.XPath("//button[contains(@class, 'login')]"));
    }
}
