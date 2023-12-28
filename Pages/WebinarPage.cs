using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class WebinarPage : BasePage
    {
        public IWebElement PayTariffStub { get; }

        public WebinarPage(IWebDriver driver) : base(driver)
        {
            PayTariffStub = driver.FindElement(By.CssSelector("[data-tid='PayTariffStub']"));
        }
    }
}
