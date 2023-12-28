using OpenQA.Selenium;

namespace SeleniumAndNUnit.CalculatorPages;

public class DecreeCalcPage : BasePage
{
    public IWebElement Iframe { get; }
    public IWebElement ButtonNext { get; }
    public IWebElement Lightbox { get; }
    public IWebElement SickList { get; }
    
    public DecreeCalcPage(IWebDriver driver) : base(driver)
    {
        Iframe = driver.FindElement(By.Id("CalcFrame"));
        ButtonNext = driver.FindElement(By.CssSelector("button__direction__right"));
        Lightbox = driver.FindElement(By.ClassName("lightbox_container"));
        SickList = driver.FindElement(By.Id("lightbox_containerSickListTexis_Cause_FancySelectControl"));
    }
}