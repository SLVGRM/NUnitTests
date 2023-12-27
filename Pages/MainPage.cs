using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class MainPage : BasePage
    {
        internal static string mainPageUrl = GetPageUrl("");
        public static IWebElement SupportMeasures { get; }
        public IWebElement BuhCalendarWidget { get; }
        public IWebElement MainTheme { get; }
        public IWebElement NewsContainer { get; }
        

        public MainPage(IWebDriver driver) : base(driver)
        {
            IWebElement SupportMeasures = driver.FindElement(By.CssSelector("[data-tid='SupportMeasures']"));
            IWebElement BuhCalendarWidget = driver.FindElement(By.CssSelector("[data-tid='BuhCalendarWidget']"));
            IWebElement MainTheme = driver.FindElement(By.CssSelector("[data-tid='MainTheme']"));
            IWebElement NewsContainer = driver.FindElement(By.CssSelector("[data-tid='NewsContainer']"));
        }
    }
}