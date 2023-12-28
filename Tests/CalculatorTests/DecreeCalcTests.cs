using FluentAssertions;
using OpenQA.Selenium;
using SeleniumAndNUnit.CalculatorPages;

namespace SeleniumAndNUnit.Tests.CalculatorTests;

public class DecreeCalcTests
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        [Test]
        ///summa
        public void DecreeCalc_IsVisible_Success ()
        {
            driver.Navigate().GoToUrl(LinksStorage.DecreeCalcPageUrl);
            DecreeCalcPage decreeCalcPage = new DecreeCalcPage(driver);
            driver.SwitchTo().Frame(decreeCalcPage.Iframe);
            driver.FindElement(By.ClassName("button__direction__right")).Click();
            var lightbox = driver.FindElement(By.Id("showErrorMessage"));
            lightbox.Displayed.Should().BeTrue();
        }
    }
}