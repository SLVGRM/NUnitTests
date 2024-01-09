using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class HospitalCalcPage : BasePage
{
    public HospitalCalcPage(IWebDriver driver)  : base(driver)
    {
    }

    public readonly string HospitalCalculator = "[data-tid='HospitalCalculator']";
}