using OpenQA.Selenium;

namespace SeleniumAndNUnit.Documents;

public class ClosedDocumentTests : BasePage
{
    public ClosedDocumentTests(IWebDriver driver)  : base(driver)
    {
    }
    
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));
}