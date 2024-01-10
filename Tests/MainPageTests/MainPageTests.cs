using OpenQA.Selenium;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit;

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
        Helpers.ElementShouldBeVisible(driver, By.ClassName(mainPage.SearchResults),false);
    }
        
    /// <summary>
    /// Проверяем, отображение MainTheme на главной
    /// </summary>
    [Test]
    public void MainPage_MainTheme_Visible()
    { 
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.MainTheme),false);
    }
        
    /// <summary>
    /// Проверяем, отображение SupportMeasures на главной
    /// </summary>
    [Test]
    public void MainPage_SupportMeasures_Visible()
    { 
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.SupportMeasures),false);
    }
        
    /// <summary>
    /// Проверяем, отображение ленты новостей на главной
    /// </summary>
    [Test]
    public void MainPage_NewsFeed_Visible()
    { 
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.NewsContainer),false);
    }
        
    /// <summary>
    /// Проверяем, отображение желтой плашки на главной
    /// </summary>
    [Test]
    public void MainPage_YellowBar_Visible()
    { 
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.YellowBar),false);
    }
}