using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.MainPageTests;

public class SearchTests : BaseTest
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
    [TestCase("2-НДФЛ")]
    public void MainPage_SearchResults_Visible(string searchText)
    {
        Helpers.WaitAndSendKeys(driver, mainPage.SearchInputBlock, searchText);
        mainPage.SearchButton.Click();
        Helpers.WaitVisibilityAndClickByClassName(driver, mainPage.SearchResults);
    }
}