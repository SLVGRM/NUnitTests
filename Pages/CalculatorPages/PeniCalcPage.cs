using OpenQA.Selenium;
namespace SeleniumAndNUnit.CalculatorPages;

public class PeniCalcPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public PeniCalcPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}