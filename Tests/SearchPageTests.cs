using OpenQA.Selenium;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.MainPageTests;

public class SearchPageTests : BaseTest
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
    [TestCase("3-НДФЛ")]
    [TestCase("4-ФСС")]
    [TestCase("НКРФ")]
    [TestCase("нологовый кодекс")]
    [TestCase("транспортный налог")]
    [TestCase("БОЧ рВФ 260602")]
    public void SearchPage_SearchResults_Visible(string searchText)
    {
        Helpers.WaitAndSendKeys(driver, mainPage.SearchInputBlock, searchText);
        mainPage.SearchButton.Click();
        Helpers.WaitVisibilityAndClickByClassName(driver, mainPage.SearchResults);
        
        /// тут логируем все ошибки из консоли, тест при этом не упадёт,
        /// вся инфа об ошибках будет в логах теста
        Helpers.Logging(driver);
    }
    
    /// <summary>
    /// Проверяем что отображается страница ничего не найдено
    /// </summary>
    [TestCase("!№;%@@")]
    public void SearchPage_NotFoundBlock_Visible(string searchText)
    {
        Helpers.WaitAndSendKeys(driver, mainPage.SearchInputBlock, searchText);
        mainPage.SearchButton.Click();
        Helpers.WaitVisibilityAndClickByCssSelector(driver, mainPage.NotFoundBlock);
        
        /// тут логируем все ошибки из консоли, тест при этом не упадёт,
        /// вся инфа об ошибках будет в логах теста
        Helpers.Logging(driver);
    }
}