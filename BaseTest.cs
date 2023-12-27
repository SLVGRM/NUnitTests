using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAndNUnit
{
    public class BaseTest
    {
        protected IWebDriver _driver;
        protected WebinarPage _webinarPage;
        protected MainPage _mainPage;
        

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _webinarPage = new WebinarPage(_driver);
            _mainPage = new MainPage(_driver);
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}