using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class HospitalCalcPage : BasePage
{
    public HospitalCalcPage(IWebDriver driver) : base(driver)
    {
    }

    public readonly string DisabilityPeriodBegin = "[data-tid='DisabilityPeriodFrom']";
    public readonly string DisabilityPeriodEnd = "[data-tid='DisabilityPeriodTo']";
    public readonly string SubmitButton = "[data-tid='HospitalCalculatorSubmit'] > *:first-of-type";
    public readonly string InsuranceExperience = "[data-tid='RadioGroup__root'] > *:last-of-type";
    public readonly string TodayButton = "[data-tid='Picker__todayWrapper']";
    public readonly string NewCalculation = "[data-tid='HospitalCalculatorNewCalculate']";
}