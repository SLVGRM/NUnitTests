using OpenQA.Selenium;
using FluentAssertions;

namespace SeleniumAndNUnit
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        [Test]
        public void QueryParameters_ShouldBeCorrect_OnSearchPage()
        {
            MainPage mainPage = new MainPage(driver);
            driver.Navigate().GoToUrl(mainPage.GetmainPageUrl());
            var query = "223";
            mainPage.SearchInput.SendKeys(query);
            mainPage.SearchButton.Click();
            var url = driver.Url.ToString();
            var expectedPath = $"?query={query}&searching=true&sortby=1&searchquerysource=2&from=Main";
            var actualPath = new Uri(url).PathAndQuery;
            actualPath.Should().Contain(expectedPath);
        }
        
        [Test]
        public void QueryParameters_ShouldBeCorrect_OnSearchPage2()
        {
            var mainPageUrl = "https://normativ.kontur.ru/";
            driver.Navigate().GoToUrl(mainPageUrl);
            var query = "223";
            driver.FindElement(By.CssSelector("[data-tid='SearchInput']")).SendKeys(query);
            driver.FindElement(By.CssSelector("[data-tid='SearchSubmitButton']")).Click();
            var url = driver.Url.ToString();
            var expectedPath = $"?query={query}&searching=true&sortby=1&searchquerysource=2&from=Main";
            var actualPath = new Uri(url).PathAndQuery;
            actualPath.Should().Contain(expectedPath);
        }
    }
}