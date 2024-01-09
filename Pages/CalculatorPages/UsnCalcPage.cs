using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class UsnCalcPage : BasePage
{
    public UsnCalcPage(IWebDriver driver)  : base(driver)
    {
    }
    
    public readonly string UsnCalculator ="[data-tid='UsnCalculator']";
}