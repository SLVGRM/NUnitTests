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

    public static void WaitVisibilityAndClickByCssSelector(IWebDriver driver, string selector, bool click = false, int delay = 20)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(delay));
        if (click)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector))).Click();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector)));
        }
    }
    
    public static void WaitVisibilityAndClickById(IWebDriver driver, string selector, bool click = false, int delay = 20)
    {
        if (delay > 30)
        {
            delay = 30;
        }
        
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(delay));
        if (click)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(selector))).Click();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(selector)));
        }
    }
    
    public static void WaitVisibilityAndClickByClassName(IWebDriver driver, string selector, bool click = false, int delay = 20)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(delay));
        if (click)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(selector))).Click();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(selector)));
        }
    }

    private static void WaitAndAuthenticate(IWebDriver driver, string login, string pass, int delay = 20)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(delay));
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-tid='i-login']"))).SendKeys(login);
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[data-tid='Input__root']"))).SendKeys(pass);
    }
    
    public static void WaitAndSendKeys(IWebDriver driver, string selector, string keys, int delay = 20)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(delay));
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector))).SendKeys(keys);
    }
    
    public static void Logging(IWebDriver driver)
    {
        var logs = driver.Manage().Logs.GetLog(LogType.Browser);

        foreach (var logEntry in logs)
        {
            if (logEntry.Level == LogLevel.Severe) // Проверяем наличие ошибок
            {
                TestContext.Out.WriteLine($"Ошибка в консоли: {logEntry.Message}");
                return;
            }
        }
    }
}