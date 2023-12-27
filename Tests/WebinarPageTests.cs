using NUnit.Framework;
using FluentAssertions;

namespace SeleniumAndNUnit
{
    [TestFixture]
    public class WebinarPageTests : BaseTest
    {
        [Test]
        public void GoToWebinarPage_PayTariffStub_ShouldBeVisible()
        {
            var webinarPage = new WebinarPage(_driver);
            _driver.Navigate().GoToUrl(WebinarPage.webinarsPageUrl);
        }
    }
}