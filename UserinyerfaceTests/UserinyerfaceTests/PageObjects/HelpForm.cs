using OpenQA.Selenium;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;

namespace UserinyerfaceTests.PageObjects
{
    public class HelpForm : Form
    {
        private IButton _sendToBottomButton => ElementFactory.GetButton(By.XPath("//button[contains(@class, 'help-form__send-to-bottom-button')]"), "Send to bottom");

        public HelpForm() : base(By.XPath("//h2[contains(@class, 'help-form__title')]"), "Help form title") { }

        public void ClickSendToBottomButton() => _sendToBottomButton.Click();
    }
}
