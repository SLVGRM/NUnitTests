using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class UsnCalcPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public UsnCalcPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}