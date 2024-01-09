using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class PeniCalcPage : BasePage
{
    public PeniCalcPage(IWebDriver driver)  : base(driver)
    {
    }
    
    public string PeniCalc = "penicalc-calculator-data";
}