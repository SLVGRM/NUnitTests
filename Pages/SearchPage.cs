using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class SearchPage : BasePage
{
    public SearchPage(IWebDriver driver) : base(driver)
    {
    }
    
    public IWebElement SearchResults => FindElement(By.ClassName("search-result__items"));
}