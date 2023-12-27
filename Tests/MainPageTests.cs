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
            _driver.Navigate().GoToUrl(MainPage.mainPageUrl);
            var searchInput = _driver.FindElement(By.CssSelector("[data-tid='SearchInput']"));
            string query = "223";
            searchInput.Click();
            searchInput.SendKeys(query);
            _driver.FindElement(By.CssSelector("[data-tid='SearchSubmitButton']")).Click();
            var url = _driver.Url.ToString();
            var expectedPath = $"?query={query}&searching=true&sortby=1&searchquerysource=2&from=Main";
            var actualPath = new Uri(url).PathAndQuery;
            actualPath.Should().Contain(expectedPath);
        }
    }
}