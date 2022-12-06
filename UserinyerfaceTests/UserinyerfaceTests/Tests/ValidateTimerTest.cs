using Aquality.Selenium.Browsers;
using NUnit.Framework;
using UserinyerfaceTests.CustomUtilities;
using UserinyerfaceTests.PageObjects.RegistrationPage;
using UserinyerfaceTests.Configuration;

namespace UserinyerfaceTests.Tests
{
    public class ValidateTimerTest : BaseTest
    {
        public RegistrationPage RegistrationPage = new RegistrationPage();

        [Test]
        public void ValidateTimer()
        {
            AqualityServices.Browser.GoTo(ConfigManager.Get("WebAppURL"));
            HomePage.ClickHereButton();
            int? actualTimeOnTimer = RegistrationPage.TimerText.GetNumberFromText();
            int expectedTimeOnTimer = 0;
            Assert.AreEqual(expectedTimeOnTimer, actualTimeOnTimer, "Timer does not start at 00:00:00");
        }
    }
}
