using KinopoiskTests.ElementsWork;
using OpenQA.Selenium;

namespace KinopoiskTests.Pages
{
    public abstract class BasePage
    {
        protected By _titleLocator;
        protected string _title;
        public static string _titleForm;

        protected BasePage(By titleLocator, string title)
        {
            _titleLocator = titleLocator;
            _title = _titleForm = title;
            AssertIsOpen();
        }

        public void AssertIsOpen()
        {
            var label = new BaseElement(_titleLocator, _title);
            label.WaitElementIsVisible();
        }
    }
}
