using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class DecreeCalcPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public DecreeCalcPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}