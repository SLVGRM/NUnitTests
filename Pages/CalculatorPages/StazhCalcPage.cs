using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class StazhCalcPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public StazhCalcPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}