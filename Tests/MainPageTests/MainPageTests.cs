using OpenQA.Selenium;
using FluentAssertions;
using NUnit.Framework;

namespace SeleniumAndNUnit
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        [Test]
        public void QueryParameters_ShouldBeCorrect_OnSearchPage()
        {
            driver.Navigate().GoToUrl(LinksStorage.mainPageUrl);
            MainPage mainPage = new MainPage(driver);
            var query = "223";
            mainPage.SearchInput.SendKeys(query);
            mainPage.SearchButton.Click();
            var url = driver.Url.ToString();
            var expectedPath = $"?query={query}&searching=true&sortby=1&searchquerysource=2&from=Main";
            var actualPath = new Uri(url).PathAndQuery;
            actualPath.Should().Contain(expectedPath);
        }
    }
}