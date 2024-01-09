using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaSharedQuestionsPage : BasePage
{
    public QaSharedQuestionsPage(IWebDriver driver) : base(driver)
    {
    }
    public IWebElement ElementName =>  FindElement(By.CssSelector("selector"));
}