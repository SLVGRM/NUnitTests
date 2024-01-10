using OpenQA.Selenium;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.WebinarTests;

[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
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
        Helpers.WaitVisibilityAndClickByCssSelector(driver, webinarPage.PayTariffStub);
    }
        
    [Test]
    public void GoToWebinarPageByPaidUser_WebinarItem_ShouldBeVisible()
    {
        Helpers.BrowseByUser(driver, true); 
        Helpers.WaitVisibilityAndClickByClassName(driver, webinarPage.WebinarItem, true);
    }
        
    [Test]
    public void GoToWebinarPageByDemoUser_TurboStub_ShouldBeVisible()
    {
        Helpers.BrowseByUser(driver, false); 
        Helpers.WaitVisibilityAndClickByCssSelector(driver, webinarPage.TurboStub);
    }
}