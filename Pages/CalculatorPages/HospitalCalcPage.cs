using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class HospitalCalcPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public HospitalCalcPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}