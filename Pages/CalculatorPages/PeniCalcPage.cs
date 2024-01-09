using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class PeniCalcPage : BasePage
{
    public PeniCalcPage(IWebDriver driver)  : base(driver)
    {
    }
    
    public readonly string PeniCalc = "penicalc-calculator-data";
}