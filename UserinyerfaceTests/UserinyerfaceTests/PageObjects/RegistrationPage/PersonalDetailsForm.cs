using OpenQA.Selenium;
using Aquality.Selenium.Forms;

namespace UserinyerfaceTests.PageObjects.RegistrationPage
{
    public class PersonalDetailsForm : Form
    {
        public PersonalDetailsForm() : base(By.XPath("//div[contains(@class, 'slider__track')]"), "Slider") { }
    }
}
