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
            driver.Navigate().GoToUrl(WebinarPage.GetWebinarsPageUrl());
            WebinarPage.PayTariffStub.Displayed.Should().BeTrue();
        }
    }
}