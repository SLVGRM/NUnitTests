using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class PeniCalcPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public PeniCalcPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}