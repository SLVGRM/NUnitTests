using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class FavoritesPage : BasePage
{
    public Stubs stubs { get; }
    
    public FavoritesPage(IWebDriver driver, Stubs stubs) : base(driver)
    {
        this.stubs = stubs;
    }
}