using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAndNUnit
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        /// <summary>
        /// Проверяем что поиск работает
        /// </summary>
        [Test]
        public void MainPage_Searching_Success()
        {
            driver.Navigate().GoToUrl(LinksStorage.mainPageUrl);
            MainPage mainPage = new MainPage(driver); //Как избавиться от инициализации?
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
            driver.Navigate().GoToUrl(LinksStorage.mainPageUrl);
            MainPage mainPage = new MainPage(driver); //Как избавиться от инициализации?
            mainPage.MainTheme.Displayed.Should().BeTrue("разобраться почему коммент невидно, " +
                                                         "возможно как раз из-за ошибки при инициализации MainPage");
            mainPage.SupportMeasures.Displayed.Should().BeTrue();
            mainPage.NewsContainer.Displayed.Should().BeTrue();
        }
    }
}