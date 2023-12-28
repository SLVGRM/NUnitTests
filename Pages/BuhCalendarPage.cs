using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class BuhCalendarPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public BuhCalendarPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}