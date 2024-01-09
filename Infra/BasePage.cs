using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class BasePage
{
    protected readonly IWebDriver driver;

    public BasePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void NavigateToUrl(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    public IWebElement FindElement(By by)
    {
        return driver.FindElement(by);
    }
}