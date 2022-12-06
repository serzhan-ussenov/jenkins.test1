using OpenQA.Selenium;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;

namespace UserinyerfaceTests.PageObjects.RegistrationPage
{
    public class RegistrationPage : Form
    {
        private ILabel _timer => ElementFactory.GetLabel(By.XPath("//div[contains(@class, 'timer')]"), "Timer");
        
        public string TimerText => _timer.Text;

        public EmailPasswordForm EmailPasswordForm { get; } = new EmailPasswordForm();

        public AvatarInterestsForm AvatarInterestsForm { get; } = new AvatarInterestsForm();

        public PersonalDetailsForm PersonalDetailsForm { get; } = new PersonalDetailsForm();

        public HelpForm HelpForm { get; } = new HelpForm();

        public CookiesForm CookiesForm { get; } = new CookiesForm();

        public RegistrationPage() : base(By.XPath("//div[contains(@class, 'timer')]"), "Timer") { }
    }
}
