using OpenQA.Selenium;

namespace SeleniumAndNUnit.Documents;

public class OpenedDocumentTests : BasePage
{
    public OpenedDocumentTests(IWebDriver driver) : base(driver)
    {
    }
    
    public IWebElement ElementName => FindElement(By.CssSelector("selector"));

    public string PartOfDocument = "js-doc-text-content-part-1";
}