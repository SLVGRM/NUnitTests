using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
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
        /// Проверяем что поиск работает
        /// </summary>
        [Test]
        public void MainPage_Searching_Success()
        { 
            mainPage.SearchInput.SendKeys("Налоговый кодекс");
            mainPage.SearchButton.Click();
            Hellpers.ElementShouldBeVisible(driver, By.ClassName(mainPage.SearchResults));
        }
        
        /// <summary>
        /// Проверяем, что загрузились блоки главной темы, мер поддержки и ленты
        /// </summary>
        [Test]
        public void MainPage_MainBlocks_Visible()
        { 
            Hellpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.MainTheme));
            Hellpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.SupportMeasures));
            Hellpers.ElementShouldBeVisible(driver, By.CssSelector(mainPage.NewsContainer));
        }
    }
}