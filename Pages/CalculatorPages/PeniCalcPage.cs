using OpenQA.Selenium;
namespace SeleniumAndNUnit.CalculatorPages;

public class PeniCalcPage : BasePage
{
    public PeniCalcPage(IWebDriver driver)  : base(driver)
    {
    }
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));
}