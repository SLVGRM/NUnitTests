using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class WebinarPage : BasePage
    {
        internal static string webinarsPageUrl = GetPageUrl("webinars");
        public static IWebElement PayTariffStub { get; }

        public WebinarPage(IWebDriver driver) : base(driver)
        {
            IWebElement PayTariffStub = driver.FindElement(By.CssSelector("[data-tid='PayTariffStub']"));
        }
    }
}
