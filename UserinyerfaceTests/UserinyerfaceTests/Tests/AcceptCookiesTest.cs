using Aquality.Selenium.Browsers;
using NUnit.Framework;
using UserinyerfaceTests.PageObjects.RegistrationPage;
using UserinyerfaceTests.Configuration;

namespace UserinyerfaceTests.Tests
{
    public class AcceptCookiesTest : BaseTest
    {
        public RegistrationPage RegistrationPage = new RegistrationPage();

        [Test]
        public void AcceptCookies()
        {
            AqualityServices.Browser.GoTo(ConfigManager.Get("WebAppURL"));
            Assert.IsTrue(HomePage.State.WaitForDisplayed(), "Home page is not opened");

            HomePage.ClickHereButton();
            RegistrationPage.CookiesForm.ClickAcceptButton();
            Assert.IsTrue(RegistrationPage.CookiesForm.State.WaitForNotDisplayed(), "Cookies form is not closed");
        }
    }
}
