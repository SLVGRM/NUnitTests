using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class HospitalCalcPage : BasePage
{
    public HospitalCalcPage(IWebDriver driver)  : base(driver)
    {
    }
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));
}