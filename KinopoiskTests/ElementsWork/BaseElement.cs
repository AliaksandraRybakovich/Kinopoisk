using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Drawing;

namespace KinopoiskTests.ElementsWork
{
    public class BaseElement: IWebElement
    {
        private IWebDriver _driver;
        private IWebElement _element;
        By _locator;

        SelectElement _select;

        WebDriverWait _waitStateElement;

        public bool Displayed
        {
            get
            {
                WaitElementIsVisible();
                return _element.Displayed;
            }
        }

        public bool Enabled
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Point Location
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Selected
        {
            get
            {
                WaitElementIsSelected();
                return _element.Selected;
            }
        }

        public Size Size
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string TagName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Text
        {
            get
            {
                WaitElementIsVisible();
                return _element.Text;
            }
        }
               

        public BaseElement(By locator)
        {
            this._locator = locator;
            _driver = Browser.Browser.GetDriver();
            _element = _driver.FindElement(_locator);

            _waitStateElement = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
        }

        public void Clear()
        {
            WaitElementIsClikable();
            _element.Clear();
        }

        public void Click()
        {
            WaitElementIsClikable();
            _element.Click();
        }        

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            WaitElementIsVisible();
            string text = _element.GetAttribute(attributeName);
            return text;
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            WaitElementIsVisible();
            _element.SendKeys(text);
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }

        public void SendKeysDropDown(string textSelect)
        {
            WaitElementIsSelected();
            _select = new SelectElement(_element);
            _select.SelectByText(textSelect);
        }

        public void WaitElementIsVisible()
        {
            _waitStateElement.Until(ExpectedConditions.ElementIsVisible(_locator));
        }

        public void WaitElementIsClikable()
        {
            _waitStateElement.Until(ExpectedConditions.ElementToBeClickable(_locator));
        }

        public void WaitElementIsSelected()
        {
            _waitStateElement.Until(ExpectedConditions.ElementToBeSelected(_locator));
        }

        public void WaitWindow()
        {
            _waitStateElement.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_locator));
        }

        public void JavaScriptExecutor()
        {
            WaitElementIsVisible();
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)_driver;
            jsExecutor.ExecuteScript("arguments.click");
        }

       

        #region NotUsed
        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
