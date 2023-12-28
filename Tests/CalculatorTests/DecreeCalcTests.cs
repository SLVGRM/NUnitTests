using FluentAssertions;
using SeleniumAndNUnit.CalculatorPages;

namespace SeleniumAndNUnit.Tests.CalculatorTests;

public class DecreeCalcTests
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        [Test]
        public void DecreeCalc_IsVisible_Success ()
        {
            driver.Navigate().GoToUrl(LinksStorage.DecreeCalcPageUrl);
            DecreeCalcPage decreeCalcPage = new DecreeCalcPage(driver);
            driver.SwitchTo().Frame(decreeCalcPage.Iframe);
            decreeCalcPage.SickList.Displayed.Should().BeTrue();
            // decreeCalcPage.ButtonNext.Click();
            // decreeCalcPage.Lightbox.Displayed.Should().BeTrue();
        }
    }
}