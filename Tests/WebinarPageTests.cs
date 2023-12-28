using NUnit.Framework;
using FluentAssertions;
using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    [TestFixture]
    public class WebinarPageTests : BaseTest
    {
        
        [Test]
        public void GoToWebinarPage_PayTariffStub_ShouldBeVisible()
        {
            driver.Navigate().GoToUrl(LinksStorage.WebinarsPageUrl);
            WebinarPage webinarPage = new WebinarPage(driver);
            webinarPage.PayTariffStub.Displayed.Should().BeTrue();
        }
        
        [Test]
        public void GoToWebinarPage_PayTariffStub_ShouldBeVisible2()
        {
            driver.Navigate().GoToUrl("https://normativ.kontur.ru/webinars");
            driver.FindElement(By.CssSelector("[data-tid='PayTariffStub']")).Displayed.Should().BeTrue();
        }
    }
}