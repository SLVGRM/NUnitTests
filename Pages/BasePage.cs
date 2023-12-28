using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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

        protected string GetPageUrl(string path)
        {
           var pageUrl = "https://normativ.kontur.ru/" + path;
           return pageUrl;
        }
    }
}