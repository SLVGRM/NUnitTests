using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class DecreeCalcPage : BasePage
{
    public IWebElement Iframe { get; }
    
    public DecreeCalcPage(IWebDriver driver) : base(driver)
    {
        Iframe = driver.FindElement(By.Id("CalcFrame"));
    }
}