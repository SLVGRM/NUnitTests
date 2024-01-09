using FluentAssertions;
using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    [TestFixture]
    public class WebinarPageTests : BaseTest
    {
        private WebinarPage webinarPage;

        [SetUp]
        public void Setup()
        {
            webinarPage = new WebinarPage(driver);
            webinarPage.NavigateToUrl(LinksStorage.WebinarsPageUrl);
        }

        [Test]
        public void GoToWebinarPage_PayTariffStub_ShouldBeVisible()
        {
            webinarPage.PayTariffStub.Displayed.Should().BeTrue();
        }
    }
}