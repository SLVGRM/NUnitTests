using OpenQA.Selenium;

namespace SeleniumAndNUnit;

[TestFixture]
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
        mainPage.SearchInput.SendKeys("Налоговый кодекс");
        mainPage.SearchButton.Click();
        Hellpers.ElementShouldBeVisible(driver, By.ClassName(mainPage.SearchResults));
    }
        
    /// <summary>
    /// Проверяем, отображение MainTheme на главной
    /// </summary>
    [Test]
    public void MainPage_MainTheme_Visible()
    { 
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.MainTheme));
    }
        
    /// <summary>
    /// Проверяем, отображение SupportMeasures на главной
    /// </summary>
    [Test]
    public void MainPage_SupportMeasures_Visible()
    { 
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.SupportMeasures));
    }
        
    /// <summary>
    /// Проверяем, отображение ленты новостей на главной
    /// </summary>
    [Test]
    public void MainPage_NewsFeed_Visible()
    { 
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.NewsContainer));
    }
        
    /// <summary>
    /// Проверяем, отображение желтой плашки на главной
    /// </summary>
    [Test]
    public void MainPage_YellowBar_Visible()
    { 
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.YellowBar));
    }
}