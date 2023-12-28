using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class HospitalCalcPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public HospitalCalcPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}