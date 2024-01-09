using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaAskQuestionPage : BasePage
{
    public QaAskQuestionPage(IWebDriver driver) : base(driver)
    {
    }
    
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));
}