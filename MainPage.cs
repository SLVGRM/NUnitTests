using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class MainPage : BasePage
    {
        public string mainPageUrl = "https://normativ.kontur.ru";

        public MainPage(IWebDriver driver) : base(driver)
        {
        }
    }
}