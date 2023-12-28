using OpenQA.Selenium;
namespace SeleniumAndNUnit.Documents;

public class OpenedDocumentTests : BasePage
{
    public IWebElement ElementName { get; }
    
    public OpenedDocumentTests(IWebDriver driver) : base(driver)
    {
        ElementName = driver.FindElement(By.CssSelector("selector"));
    }
}