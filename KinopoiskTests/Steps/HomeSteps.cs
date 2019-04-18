using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class HomeSteps
    {
        static HomePage homePage = new HomePage();

        public static YandexLogInPage LogIn()
        { 
            homePage.Login.Click();

            return new YandexLogInPage();
        }

        public static void ClickOnLogOutButton()
        {            
            homePage.Logo.Click();
            homePage.LogOut.Click();
        }

        public static ExtentedSearchPage ClickOnExtentedSearchButton()
        {
            homePage.ExtentedSearchButton.Click();

            return new ExtentedSearchPage();
        }        
    }
}

