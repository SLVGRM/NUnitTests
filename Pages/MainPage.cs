using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
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
        
        public IWebElement SearchInput => FindElement(By.CssSelector("[data-tid='SearchInput']"));
        public IWebElement SearchButton => FindElement(By.CssSelector("[data-tid='SearchSubmitButton']"));
    }
}