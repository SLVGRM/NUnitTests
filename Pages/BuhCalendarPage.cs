using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class BuhCalendarPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public BuhCalendarPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}