using NUnit.Framework;
using Aquality.Selenium.Browsers;
using UserinyerfaceTests.PageObjects;
using UserinyerfaceTests.Configuration;

namespace UserinyerfaceTests.Tests
{
    public class BaseTest
    {
        protected HomePage HomePage = new HomePage();

        [SetUp]
        protected void Setup()
        {
            ConfigManager.Load();
            AqualityServices.Browser.Maximize();
        }

        [TearDown]
        protected void Teardown()
        {
            AqualityServices.Browser.Quit();
        }
    }
}
