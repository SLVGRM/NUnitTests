using OpenQA.Selenium;

namespace SeleniumAndNUnit.Documents;

public class ClosedDocumentTests : BasePage
{
    public IWebElement ElementName { get; }
    
    public ClosedDocumentTests(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}