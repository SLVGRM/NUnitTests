using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class SearchPage : BasePage
{
    public IWebElement SearchResults { get; }
    
    public SearchPage(IWebDriver driver) : base(driver)
    {
        SearchResults = driver.FindElement(By.ClassName("search-result__items"));
    }
}