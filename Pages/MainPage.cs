using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class MainPage : BasePage
{
    public MainPage(IWebDriver driver) : base(driver)
    {
    }
        
    public readonly string SupportMeasures = "[data-tid='SupportMeasures']";
    public readonly string BuhCalendarWidget = "[data-tid='BuhCalendarWidget']";
    public readonly string MainTheme = "[data-tid='MainTheme']";
    public readonly string SearchResults = "search-result__items";
    public readonly string NewsContainer = "[data-tid='NewsContainer']";
    public readonly string YellowBar = "[data-tid='HeaderNotification']";
    public readonly string SearchInputBlock = "[data-tid='SearchInput']";
    
        
    public IWebElement SearchInput => FindElement(By.CssSelector(SearchInputBlock));
    public IWebElement SearchButton => FindElement(By.CssSelector("[data-tid='SearchSubmitButton']"));
}