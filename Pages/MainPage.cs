using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class MainPage : BasePage
    {
        public static IWebElement SupportMeasures { get; set; }
        public static IWebElement BuhCalendarWidget { get; set; }
        public static IWebElement MainTheme { get; set; }
        public static IWebElement NewsContainer { get; set; }
        public static IWebElement SearchInput { get; set; }
        public static IWebElement SearchButton { get; set; }

        public MainPage(IWebDriver driver) : base(driver)
        {
            SupportMeasures = driver.FindElement(By.CssSelector("[data-tid='SupportMeasures']"));
            BuhCalendarWidget = driver.FindElement(By.CssSelector("[data-tid='BuhCalendarWidget']"));
            MainTheme = driver.FindElement(By.CssSelector("[data-tid='MainTheme']"));
            NewsContainer = driver.FindElement(By.CssSelector("[data-tid='NewsContainer']"));
            SearchInput = driver.FindElement(By.CssSelector("[data-tid='SearchInput']"));
            SearchButton = driver.FindElement(By.CssSelector("[data-tid='SearchSubmitButton']"));
        }
    }
}