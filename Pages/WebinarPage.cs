using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class WebinarPage : BasePage
    {
        public string GetWebinarsPageUrl() => GetPageUrl("webinars");

        public IWebElement PayTariffStub { get; set; }

        public WebinarPage(IWebDriver driver) : base(driver)
        {
            PayTariffStub = driver.FindElement(By.CssSelector("[data-tid='PayTariffStub']"));
        }
    }
}
