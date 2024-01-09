using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class BuhCalendarPage : BasePage
{
    public BuhCalendarPage(IWebDriver driver) : base(driver)
    {
    }
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));
}