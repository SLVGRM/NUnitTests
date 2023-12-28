using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaSharedQuestionsPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public QaSharedQuestionsPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}