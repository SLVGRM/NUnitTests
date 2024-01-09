using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class WebinarPage : BasePage
    {
        public WebinarPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement PayTariffStub => FindElement(By.CssSelector("[data-tid='PayTariffStub']"));
    }
}
