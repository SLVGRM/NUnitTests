using OpenQA.Selenium;
namespace SeleniumAndNUnit.CalculatorPages;

public class VacationCalcPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public VacationCalcPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}