using OpenQA.Selenium;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;
using System.Collections.Generic;

namespace UserinyerfaceTests.PageObjects.RegistrationPage
{
    public class EmailPasswordForm : Form
    {
        private ITextBox _passwordTextBox => ElementFactory.GetTextBox(By.XPath("(//input[contains(@class, 'input')])[1]"), "Password");

        private ITextBox _emailNameTextBox => ElementFactory.GetTextBox(By.XPath("(//input[contains(@class, 'input')])[2]"), "Email name");
        
        private ITextBox _emailDomainTextBox => ElementFactory.GetTextBox(By.XPath("(//input[contains(@class, 'input')])[3]"), "Email domain");
        
        private IButton _dropdownOpenerButton => ElementFactory.GetButton(By.XPath("//div[@class = 'dropdown__opener']"), "Drop-down menu opener");
        
        private ICheckBox _termsConditionsCheckBox => ElementFactory.GetCheckBox(By.XPath("//span[@class = 'checkbox__box']"), "Terms and conditions checkbox");
        
        private IButton _nextButton => ElementFactory.GetButton(By.XPath("//a[@class = 'button--secondary']"), "Next button");

        private IList<ILabel> EmailTopLevelDomainLabels => ElementFactory.FindElements<ILabel>(By.XPath("//div[contains(@class, 'dropdown__list-item')]"));

        public EmailPasswordForm() : base(By.XPath("//span[contains(@class, 'terms-conditions')]"), "Terms and conditions") { }

        public void PasswordTextBoxClearType(string text) => _passwordTextBox.ClearAndType(text);

        public void EmailNameTextBoxClearType(string text) => _emailNameTextBox.ClearAndType(text);

        public void EmailDomainTextBoxClearType(string text) => _emailDomainTextBox.ClearAndType(text);

        public void SelectEmailTopLevelDomain(string text)
        {
            _dropdownOpenerButton.Click();

            foreach (ILabel emailTLDLabel in EmailTopLevelDomainLabels)
            {
                if (text.Equals(emailTLDLabel.Text))
                {
                    emailTLDLabel.Click();
                    break;
                }
            }
        }

        public void ClickTermsConditionsCheckBox() => _termsConditionsCheckBox.Check();

        public void ClickNextButton() => _nextButton.Click();
    }
}
