using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("search-result__items")));
        }
        
        /// <summary>
        /// Проверяем, что загрузились блоки главной темы, мер поддержки и ленты
        /// </summary>
        [Test]
        public void MainPage_MainBlocks_Visible()
        { 
            mainPage.MainTheme.Displayed.Should().BeTrue();
            mainPage.SupportMeasures.Displayed.Should().BeTrue();
            mainPage.NewsContainer.Displayed.Should().BeTrue();
        }
    }
}