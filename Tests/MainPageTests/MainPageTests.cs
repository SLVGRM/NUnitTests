using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            GoToMain();
            MainPage.SearchInput.SendKeys("Налоговый кодекс");
            MainPage.SearchButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("search-result__items")));
        }
        
        /// <summary>
        /// Проверяем, что загрузились блоки главной темы, мер поддержки и ленты
        /// </summary>
        [Test]
        public void MainPage_MainBlocks_Visible()
        {
            GoToMain();
            MainPage.MainTheme.Displayed.Should().BeTrue("разобраться почему коммент невидно, " +
                                                         "возможно как раз из-за ошибки при инициализации MainPage");
            MainPage.SupportMeasures.Displayed.Should().BeTrue();
            MainPage.NewsContainer.Displayed.Should().BeTrue();
        }
        
        /// <summary>
        /// Проверяем, что загрузились новости в ленте
        /// </summary>
        
        public void GoToMain()
        {
            driver.Navigate().GoToUrl(LinksStorage.mainPageUrl);
            MainPage mainPage = new MainPage(driver); //Как избавиться от инициализации?
        }
    }
}