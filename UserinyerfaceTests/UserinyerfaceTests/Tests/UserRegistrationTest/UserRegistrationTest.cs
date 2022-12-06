using Aquality.Selenium.Browsers;
using NUnit.Framework;
using UserinyerfaceTests.BusinessObjects;
using UserinyerfaceTests.CustomUtilities;
using UserinyerfaceTests.PageObjects.RegistrationPage;
using UserinyerfaceTests.Configuration;

namespace UserinyerfaceTests.Tests.UserRegistrationTest.TestData
{
    public class UserRegistrationTest : BaseTest
    {
        public RegistrationPage RegistrationPage = new RegistrationPage();

        [TestCaseSource(typeof(TestDataSource<User>))]
        public void UserRegistration(User user)
        {
            AqualityServices.Browser.GoTo(ConfigManager.Get("WebAppURL"));
            Assert.IsTrue(HomePage.State.WaitForDisplayed(), "Home page is not opened");

            HomePage.ClickHereButton();
            Assert.IsTrue(RegistrationPage.EmailPasswordForm.State.WaitForDisplayed(), "Login form is not opened");

            RegistrationPage.EmailPasswordForm.PasswordTextBoxClearType(user.Password);
            RegistrationPage.EmailPasswordForm.EmailNameTextBoxClearType(user.EmailUserName);
            RegistrationPage.EmailPasswordForm.EmailDomainTextBoxClearType(user.EmailDomain);
            RegistrationPage.EmailPasswordForm.SelectEmailTopLevelDomain(user.EmailTopLevelDomain);
            RegistrationPage.EmailPasswordForm.ClickTermsConditionsCheckBox();
            RegistrationPage.EmailPasswordForm.ClickNextButton();
            Assert.IsTrue(RegistrationPage.AvatarInterestsForm.State.WaitForDisplayed(), "Avatar and interests form is opened");

            RegistrationPage.AvatarInterestsForm.UploadAvatar(user.AvatarName);
            RegistrationPage.AvatarInterestsForm.SelectInerests(user.Interests);
            RegistrationPage.AvatarInterestsForm.ClickNextButton();
            Assert.IsTrue(RegistrationPage.PersonalDetailsForm.State.WaitForDisplayed(), "Personal details form is not opened");
        }
    }
}
