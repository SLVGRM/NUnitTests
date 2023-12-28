using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaAskQuestionPage : BaseTest
{
    public IWebElement ElementName { get; }
    
    public QaAskQuestionPage(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}