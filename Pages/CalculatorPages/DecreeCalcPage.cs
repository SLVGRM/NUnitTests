using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class DecreeCalcPage : BaseTest
{
    public IWebElement Iframe { get; }
    
    public DecreeCalcPage(IWebDriver driver) : base()
    {
        Iframe = driver.FindElement(By.Id("CalcFrame"));
    }
}