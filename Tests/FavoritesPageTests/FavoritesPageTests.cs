using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.FavoritesPageTests;


[TestFixture]
public class FavoritesPageTests : BaseTest
{
    private FavoritesPage favoritesPage;
    
    [SetUp]
    public void Setup()
    {
        var stubs = new Stubs();
        favoritesPage = new FavoritesPage(driver, stubs);
        favoritesPage.NavigateToUrl(LinksStorage.FavoritesPageUrl);
    }
    
    /// <summary>
    /// Проверяем что большой док загружается за меньше 8 секунд
    /// </summary>
    [Test]
    public void FavoritesPage_OpenByGuest_StubVisible()
    {
        driver.Navigate().GoToUrl(LinksStorage.FavoritesPageUrl);
        Helpers.WaitVisibilityAndClickByCssSelector(driver, favoritesPage.stubs.UnAuthorizedStub);
    }
}