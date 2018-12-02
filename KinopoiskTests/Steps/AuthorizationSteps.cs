using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class AuthorizationSteps
    {
        static AuthorizationPage authorizationPage = new AuthorizationPage();
                
        public static void ClickOnButtonExtenteSocialPanel()
        {
            Browser.Browser.GetDriver().SwitchTo().Frame(authorizationPage.socialPanel);
            authorizationPage.extenteSocialPanel.Click();
        }
      
        public static void ClickOnButtonYandex()
        {
            authorizationPage.yandexButton.Click();
        }        
    }
}
