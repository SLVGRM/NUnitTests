using OpenQA.Selenium;

namespace SeleniumAndNUnit.Documents;

public class ClosedDocumentTests : BaseTest
{
    public IWebElement ElementName { get; }
    
    public ClosedDocumentTests(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}