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
            WebinarPage webinarPage = new WebinarPage(driver);
            driver.Navigate().GoToUrl(webinarPage.GetWebinarsPageUrl());
            webinarPage.PayTariffStub.Displayed.Should().BeTrue();
        }
    }
}