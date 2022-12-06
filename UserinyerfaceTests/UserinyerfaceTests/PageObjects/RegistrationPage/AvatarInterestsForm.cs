using OpenQA.Selenium;
using Aquality.Selenium.Forms;
using Aquality.Selenium.Elements.Interfaces;
using System.Collections.Generic;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;
using UserinyerfaceTests.Tests.UserRegistrationTest.TestData;
using System.IO;

namespace UserinyerfaceTests.PageObjects.RegistrationPage
{
    public class AvatarInterestsForm : Form
    {
        private IButton _uploadButton => ElementFactory.GetButton(By.XPath("//a[@class = 'avatar-and-interests__upload-button']"), "Upload button");

        private IButton _nextButton => ElementFactory.GetButton(By.XPath("//button[text()[contains(., 'Next')]]"), "Next button");

        private ICheckBox _unselectallCheckBox => ElementFactory.GetCheckBox(By.CssSelector("label[for='interest_unselectall']"), "Unselect all");

        public AvatarInterestsForm() : base(By.XPath("//a[@class = 'avatar-and-interests__upload-button']"), "Upload button") { }

        public void UploadAvatar(string avatarName)
        {
            string avatarFilePath = Path.Combine(TestDataManager.GetFullPathToFile("UserAvatarFolderName"), ($"{avatarName}.jpg"));
            _uploadButton.Click();
            Thread.Sleep(5000);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.TextEntry(avatarFilePath);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        public void SelectInerests(List<string> inputInterestsList)
        {
            _unselectallCheckBox.Click();

            foreach(string inputInterest in inputInterestsList)
            {
                ElementFactory.GetCheckBox(By.CssSelector($"label[for='interest_{inputInterest.ToLower()}']"), $"{inputInterest} checkbox").Click();
            }
        }

        public void ClickNextButton() => _nextButton.Click();
    }
}
