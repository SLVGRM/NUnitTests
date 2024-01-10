using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAndNUnit;

public class Hellpers
{
    public static void BrowseByUser(IWebDriver driver, bool isPaid)
    {
        string buttonSelector = "[data-tid='Button__root']";
        string topBarLogin = "[data-tid='TopBarLogin']";


        ElementShouldBeVisible(driver, By.CssSelector(topBarLogin), true);

        if (isPaid)
        {
            WaitAndSendKeys(driver, "Iam97@tester.ru", "123123");
        }
        else
        {
            var credentials = "folmonumle@gufum.com";
            WaitAndSendKeys(driver, credentials, credentials);
        }

        driver.FindElement(By.CssSelector(buttonSelector)).Click();
    }

    public static void ElementShouldBeVisible(IWebDriver driver, By by, bool click)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        if (click)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(by)).Click();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }

    private static void WaitAndSendKeys(IWebDriver driver, string login, string pass)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-tid='i-login']"))).SendKeys(login);
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-tid='Input__root']"))).SendKeys(pass);
    }
}