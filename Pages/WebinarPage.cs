using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class WebinarPage : BasePage
{
    public WebinarPage(IWebDriver driver) : base(driver)
    {
    }
        
    public readonly string PayTariffStub = "[data-tid='PayTariffStub']";
    public readonly string WebinarItem = "webinar-item-image-overlay";
    public readonly string TurboStub = "[data-tid='TurboModeStub']";
}