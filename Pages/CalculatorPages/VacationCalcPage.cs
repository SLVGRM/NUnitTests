using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class VacationCalcPage : BasePage
{
    public VacationCalcPage(IWebDriver driver)  : base(driver)
    {
    }
    
    public IWebElement Iframe => FindElement(By.Id("CalcFrame"));
    
    public string Hint = "PeriodExclusionsHintIcon";
}