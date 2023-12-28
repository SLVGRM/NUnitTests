using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaAskQuestionPage : BasePage
{
    public IWebElement ElementName { get; }
    
    public QaAskQuestionPage(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}