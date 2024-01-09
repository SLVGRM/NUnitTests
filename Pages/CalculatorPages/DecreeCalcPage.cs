using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class DecreeCalcPage : BasePage
{
    public DecreeCalcPage(IWebDriver driver) : base(driver)
    {
    }
    
    public IWebElement Iframe => FindElement(By.Id("CalcFrame"));

    public string RadioButtonsBlock = "SickListTexis_ChildrenNumber_NullableEnumRadioGroupControl";
}