using OpenQA.Selenium;
using SeleniumAndNUnit.CalculatorPages;

namespace SeleniumAndNUnit.Tests.CalculatorTests;

public class CalcTests
{
    [TestFixture]
    public class CalcPageTests : BaseTest
    {
        /// <summary>
        /// Проверяем, что калькулятор декретных загрузился
        /// </summary>
        [Test]
        public void DecreeCalc_IsVisible_Success()
        {
            driver.Navigate().GoToUrl(LinksStorage.DecreeCalcPageUrl);
            DecreeCalcPage decreeCalc = new DecreeCalcPage(driver);
            driver.SwitchTo().Frame(decreeCalc.Iframe);
            Hellpers.ElementShouldBeVisible(driver, By.Id(decreeCalc.RadioButtonsBlock));
        }
        
        /// <summary>
        /// Проверяем, что калькулятор больничных загрузился
        /// </summary>
        [Test]
        public void HospitalCalc_IsVisible_Success()
        {
            driver.Navigate().GoToUrl(LinksStorage.HositalCalcPageUrl);
            HospitalCalcPage hospitalCalc = new HospitalCalcPage(driver);
            Hellpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.HospitalCalculator));
        }
        
        /// <summary>
        /// Проверяем, что калькулятор пени загрузился
        /// </summary>
        [Test]
        public void PeniCalc_IsVisible_Success()
        {
            driver.Navigate().GoToUrl(LinksStorage.PeniCalcPageUrl);
            PeniCalcPage peniCalc = new PeniCalcPage(driver);
            Hellpers.ElementShouldBeVisible(driver, By.ClassName(peniCalc.PeniCalc));
        }
        
        /// <summary>
        /// Проверяем, что калькулятор Усн загрузился
        /// </summary>
        [Test]
        public void UsnCalculator_IsVisible_Success()
        {
            driver.Navigate().GoToUrl(LinksStorage.UsnCalcPageUrl);
            UsnCalcPage usnCalculator = new UsnCalcPage(driver);
            Hellpers.ElementShouldBeVisible(driver, By.CssSelector(usnCalculator.UsnCalculator));
        }
        
        /// <summary>
        /// Проверяем, что калькулятор отпускных загрузился
        /// </summary>
        [Test]
        public void VacationCalc_IsVisible_Success()
        {
            driver.Navigate().GoToUrl(LinksStorage.VacationCalcPageUrl);
            VacationCalcPage vacationCalc = new VacationCalcPage(driver);
            driver.SwitchTo().Frame(vacationCalc.Iframe); 
            Hellpers.ElementShouldBeVisible(driver, By.Id(vacationCalc.Hint));
        }
    }
}