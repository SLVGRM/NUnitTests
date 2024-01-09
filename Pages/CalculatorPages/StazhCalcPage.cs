using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class StazhCalcPage : BasePage
{
    public StazhCalcPage(IWebDriver driver) : base(driver)
    {
    }
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));
}