using OpenQA.Selenium;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;

namespace UserinyerfaceTests.PageObjects
{
   public class CookiesForm : Form
    {
        private IButton _acceptButton => ElementFactory.GetButton(By.XPath("//button[text()[contains(., 'Not really, no')]]"), "Accept cookies");

        public CookiesForm() : base(By.XPath("//p[@class = 'cookies__message']"), "Cookies message") { }

        public void ClickAcceptButton() => _acceptButton.Click();
    }
}
