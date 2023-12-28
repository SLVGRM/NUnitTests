using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class StazhCalcPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public StazhCalcPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}