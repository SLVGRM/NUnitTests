using OpenQA.Selenium;
namespace SeleniumAndNUnit.CalculatorPages;

public class VacationCalcPage : BasePage
{
    public VacationCalcPage(IWebDriver driver)  : base(driver)
    {
    }
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));
}