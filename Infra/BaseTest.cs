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
        options.AddArguments("start-maximized", "--disable-extensions", "--no-sandbox");
        // options.AddArgument("--headless=new");
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(8000);
    }

    [TearDown]
    public void Cleanup()
    {
        driver.Close();
        driver.Quit();
    }
}