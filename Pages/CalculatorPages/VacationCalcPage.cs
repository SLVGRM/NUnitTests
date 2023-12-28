using OpenQA.Selenium;
namespace SeleniumAndNUnit.CalculatorPages;

public class VacationCalcPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public VacationCalcPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}