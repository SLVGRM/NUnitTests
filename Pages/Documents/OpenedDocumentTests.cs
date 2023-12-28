using OpenQA.Selenium;
namespace SeleniumAndNUnit.Documents;

public class OpenedDocumentTests : BaseTest
{
    public IWebElement ElementName { get; }
    
    public OpenedDocumentTests(IWebDriver driver) : base()
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}