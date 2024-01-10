using OpenQA.Selenium;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.MainPageTests;

[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
public class MainPageTests : BaseTest
{
    private MainPage mainPage;

    [SetUp]
    public void Setup()
    {
        mainPage = new MainPage(driver);
        mainPage.NavigateToUrl(LinksStorage.mainPageUrl);
    }
    
    /// <summary>
    /// Проверяем что отображается поисковая выдача
    /// </summary>
    [Test]
    public void MainPage_SearchResults_Visible()
    {
        Helpers.WaitAndSendKeys(driver, mainPage.SearchInputBlock, "Налоговый кодекс");
        mainPage.SearchButton.Click();
        Helpers.WaitVisibilityAndClickByClassName(driver, mainPage.SearchResults);
    }
        
    /// <summary>
    /// Проверяем, отображение MainTheme на главной
    /// </summary>
    [Test]
    public void MainPage_MainTheme_Visible()
    { 
        Helpers.WaitVisibilityAndClickByCssSelector(driver, mainPage.MainTheme);
    }
        
    /// <summary>
    /// Проверяем, отображение SupportMeasures на главной
    /// </summary>
    [Test]
    public void MainPage_SupportMeasures_Visible()
    { 
        Helpers.WaitVisibilityAndClickByCssSelector(driver, mainPage.SupportMeasures);
    }
        
    /// <summary>
    /// Проверяем, отображение ленты новостей на главной
    /// </summary>
    [Test]
    public void MainPage_NewsFeed_Visible()
    { 
        Helpers.WaitVisibilityAndClickByCssSelector(driver, mainPage.NewsContainer);
    }
        
    /// <summary>
    /// Проверяем, отображение желтой плашки на главной
    /// </summary>
    [Test]
    public void MainPage_YellowBar_Visible()
    { 
        Helpers.WaitVisibilityAndClickByCssSelector(driver, mainPage.YellowBar);
    }
}