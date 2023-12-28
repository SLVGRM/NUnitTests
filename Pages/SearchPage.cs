using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class SearchPage : BaseTest
{
    public IWebElement SearchResults { get; }
    
    public SearchPage(IWebDriver driver) : base()
    {
        SearchResults = driver.FindElement(By.ClassName("search-result__items"));
    }
}