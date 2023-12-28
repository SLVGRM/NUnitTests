using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class UsnCalcPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public UsnCalcPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}