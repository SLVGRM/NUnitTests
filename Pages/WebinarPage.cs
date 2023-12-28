using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class WebinarPage : BaseTest
    {
        public IWebElement PayTariffStub { get; }

        public WebinarPage(IWebDriver driver) : base()
        {
            PayTariffStub = driver.FindElement(By.CssSelector("[data-tid='PayTariffStub']"));
        }
    }
}
