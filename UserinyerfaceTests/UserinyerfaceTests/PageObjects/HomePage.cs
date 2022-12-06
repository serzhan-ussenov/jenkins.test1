using OpenQA.Selenium;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;

namespace UserinyerfaceTests.PageObjects
{
    public class HomePage : Form
    {
        private IButton _hereButton => ElementFactory.GetButton(By.XPath("//a[@class = 'start__link']"), "Here");

        public HomePage() : base(By.XPath("//a[@class = 'start__link']"), "Here button") { }

        public void ClickHereButton() => _hereButton.WaitAndClick();
    }
}
