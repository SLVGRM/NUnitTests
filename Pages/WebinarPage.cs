using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class WebinarPage : BasePage
{
    public Stubs stubs { get; }
    public WebinarPage(IWebDriver driver, Stubs stubs) : base(driver)
    {
        this.stubs = stubs;
    }
    
    public readonly string PayTariffStub = "[data-tid='PayTariffStub']";
    public readonly string WebinarItem = "webinar-item-image-overlay";
}