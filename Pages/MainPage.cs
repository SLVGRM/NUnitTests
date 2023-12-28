using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class MainPage : BasePage
    {
        public string GetmainPageUrl() => GetPageUrl("");
        public IWebElement SupportMeasures { get; }
        public IWebElement BuhCalendarWidget { get; }
        public IWebElement MainTheme { get; }
        public IWebElement NewsContainer { get; }

        public MainPage(IWebDriver driver) : base(driver)
        {
            SupportMeasures = driver.FindElement(By.CssSelector("[data-tid='SupportMeasures']"));
            BuhCalendarWidget = driver.FindElement(By.CssSelector("[data-tid='BuhCalendarWidget']"));
            MainTheme = driver.FindElement(By.CssSelector("[data-tid='MainTheme']"));
            NewsContainer = driver.FindElement(By.CssSelector("[data-tid='NewsContainer']"));
        }
    }
}