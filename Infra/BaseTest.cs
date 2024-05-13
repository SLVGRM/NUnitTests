using FluentAssertions.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAndNUnit;

public class BaseTest
{
    protected IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        var options = new ChromeOptions();
        options.PageLoadStrategy = PageLoadStrategy.Eager; ///тут устанавливается стратегияожидания загрузки, подробнее тут https://barancev.github.io/slow-loading-pages/
        options.AddArguments("start-maximized", "--disable-extensions", "--no-sandbox");
        // options.AddArgument("--headless=new");
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(45);
    }

    [TearDown]
    public void Cleanup()
    {
        driver.Close();
        driver.Quit();
    }
}