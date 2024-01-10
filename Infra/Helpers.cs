using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAndNUnit.Infra;

public class Helpers
{
    public static void BrowseByUser(IWebDriver driver, bool isPaid)
    {
        string buttonSelector = "[data-tid='Button__root']";
        string topBarLogin = "[data-tid='TopBarLogin']";


        WaitVisibilityAndClickByCssSelector(driver, topBarLogin, true);

        if (isPaid)
        {
            WaitAndAuthenticate(driver, "Iam97@tester.ru", "123123");
        }
        else
        {
            var credentials = "folmonumle@gufum.com";
            WaitAndAuthenticate(driver, credentials, credentials);
        }

        driver.FindElement(By.CssSelector(buttonSelector)).Click();
    }

    public static void WaitVisibilityAndClickByCssSelector(IWebDriver driver, string selector, bool click = false)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        if (click)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector))).Click();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector)));
        }
    }
    
    public static void WaitVisibilityAndClickById(IWebDriver driver, string selector, bool click = false)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        if (click)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(selector))).Click();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(selector)));
        }
    }
    
    public static void WaitVisibilityAndClickByClassName(IWebDriver driver, string selector, bool click = false)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        if (click)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(selector))).Click();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(selector)));
        }
    }

    private static void WaitAndAuthenticate(IWebDriver driver, string login, string pass)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-tid='i-login']"))).SendKeys(login);
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-tid='Input__root']"))).SendKeys(pass);
    }
    
    public static void WaitAndSendKeys(IWebDriver driver, string selector, string keys)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector))).SendKeys(keys);
    }
}