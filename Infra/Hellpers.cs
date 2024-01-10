using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAndNUnit;

public class Hellpers
{
    public static void BrowseByUser(IWebDriver driver, bool isPaid)
    {
        string loginSelector = "[data-tid='i-login']";
        string passwordSelector = "[data-tid='Input__root']";
        string buttonSelector = "[data-tid='Button__root']";

        driver.FindElement(By.CssSelector("[data-tid='TopBarLogin']")).Click();
    
        if (isPaid)
        {
            WaitAndSendKeys(driver, By.CssSelector(loginSelector), "Iam97@tester.ru");
            WaitAndSendKeys(driver, By.CssSelector(passwordSelector), "123123");
        }
        else
        {
            var credentials = "folmonumle@gufum.com";
            WaitAndSendKeys(driver, By.CssSelector(loginSelector), credentials);
            WaitAndSendKeys(driver, By.CssSelector(passwordSelector), credentials);
        }

        driver.FindElement(By.CssSelector(buttonSelector)).Click();
    }

    public static void ElementShouldBeVisible(IWebDriver driver, By by)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(by));
    }

    private static void WaitAndSendKeys(IWebDriver driver, By by, string keys)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(by)).SendKeys(keys);
    }
}