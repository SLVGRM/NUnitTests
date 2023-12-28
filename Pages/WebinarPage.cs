using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class WebinarPage : BasePage
    {
        public string GetWebinarsPageUrl() => GetPageUrl("webinars");
        public IWebElement PayTariffStub { get; }

        public WebinarPage(IWebDriver driver) : base(driver)
        {
            IWebElement PayTariffStub = driver.FindElement(By.CssSelector("[data-tid='PayTariffStub']"));
        }
    }
}
