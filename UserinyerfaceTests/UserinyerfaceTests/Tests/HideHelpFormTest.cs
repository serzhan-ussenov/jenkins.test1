using Aquality.Selenium.Browsers;
using NUnit.Framework;
using UserinyerfaceTests.PageObjects.RegistrationPage;
using UserinyerfaceTests.Configuration;

namespace UserinyerfaceTests.Tests
{
    public class HideHelpFormTest : BaseTest
    {
        public RegistrationPage RegistrationPage = new RegistrationPage();

        [Test]
        public void HideHelpForm()
        {
            AqualityServices.Browser.GoTo(ConfigManager.Get("WebAppURL"));
            Assert.IsTrue(HomePage.State.WaitForDisplayed(), "Home page is not opened");

            HomePage.ClickHereButton();
            RegistrationPage.HelpForm.ClickSendToBottomButton();
            Assert.IsTrue(RegistrationPage.HelpForm.State.WaitForNotDisplayed(), "Help form is not hidden");
        }
    }
}
