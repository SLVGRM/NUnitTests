using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAndNUnit
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        
        public BaseTest()
        {
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}