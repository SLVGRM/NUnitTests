using OpenQA.Selenium;

namespace SeleniumAndNUnit

{
    public class BasePage : BaseTest
    {
        protected IWebDriver driver;
        
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}