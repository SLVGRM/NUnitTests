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
        public void GoToWebinarPageByGuest_PayTariffStub_ShouldBeVisible()
        {
            Hellpers.ElementShouldBeVisible(driver, By.CssSelector(webinarPage.PayTariffStub));
        }
        
        [Test]
        public void GoToWebinarPageByPaidUser_WebinarItem_ShouldBeVisible()
        {
            Hellpers.BrowseByUser(driver, true); 
            Hellpers.ElementShouldBeVisible(driver, By.ClassName(webinarPage.WebinarItem));
        }
        
        [Test]
        public void GoToWebinarPageByDemoUser_Stub_ShouldBeVisible()
        {
            Hellpers.BrowseByUser(driver, false); 
            Hellpers.ElementShouldBeVisible(driver, By.CssSelector(webinarPage.TurboStub));
        }
    }
}