using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class AuthorizationSteps
    {
        static AuthorizationPage authorizationPage = new AuthorizationPage();

        public static bool CheckAuthorizationPage()
        {
            bool isAssertAuthPage = false;
            if (authorizationPage.socialPanel.Displayed)
            {
                isAssertAuthPage = true;
            }
            return isAssertAuthPage;
        }
        
        public static void ClickOnButtonExtenteSocialPanel()
        {
            Browser.Browser.GetDriver().SwitchTo().Frame(authorizationPage.socialPanel);
            authorizationPage.extenteSocialPanel.Click();
        }

        public static bool CheckExtenteSocialPanel()
        {
            bool isAssertExtenteSocialPanel = false;
            if (authorizationPage.googleButton.Displayed)
            {
                isAssertExtenteSocialPanel = true;
            }
            return isAssertExtenteSocialPanel;
        }

        public static HomePage ClickOnButtonGoogle()
        {
            authorizationPage.googleButton.Click();
            return new HomePage();
        }        
    }
}
