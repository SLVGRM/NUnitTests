using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class WebinarPage : BasePage
    {
        public string webinarPageUrl = "https://normativ.kontur.ru/webinars";
        public WebinarPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
