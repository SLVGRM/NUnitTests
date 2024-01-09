using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }
        
        public IWebElement SupportMeasures => FindElement(By.CssSelector("[data-tid='SupportMeasures']"));
        public IWebElement BuhCalendarWidget => FindElement(By.CssSelector("[data-tid='BuhCalendarWidget']"));
        public IWebElement MainTheme => FindElement(By.CssSelector("[data-tid='MainTheme']"));
        public IWebElement NewsContainer => FindElement(By.CssSelector("[data-tid='NewsContainer']"));
        public IWebElement SearchInput => FindElement(By.CssSelector("[data-tid='SearchInput']"));
        public IWebElement SearchButton => FindElement(By.CssSelector("[data-tid='SearchSubmitButton']"));
    }
}