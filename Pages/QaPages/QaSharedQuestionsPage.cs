using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaSharedQuestionsPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public QaSharedQuestionsPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}