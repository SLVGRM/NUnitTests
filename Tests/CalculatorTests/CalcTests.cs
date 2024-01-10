using OpenQA.Selenium;
using SeleniumAndNUnit.CalculatorPages;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.CalculatorTests;

[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
public class CalcTests : BaseTest
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
        Helpers.ElementShouldBeVisible(driver, By.Id(decreeCalc.RadioButtonsBlock));
    }
        
    /// <summary>
    /// Проверяем, что калькулятор загрузился и сервис ответил
    /// </summary>
    [Test]
    public void HospitalCalc_SubmitValidCalculation_Success()
    {
        driver.Navigate().GoToUrl(LinksStorage.HositalCalcPageUrl);
        HospitalCalcPage hospitalCalc = new HospitalCalcPage(driver);
        SuccessfulHospitalCalcCalculation(hospitalCalc);
    }
        
    /// <summary>
    /// Проверяем, что калькулятор пени загрузился
    /// </summary>
    [Test]
    public void PeniCalc_IsVisible_Success()
    {
        driver.Navigate().GoToUrl(LinksStorage.PeniCalcPageUrl);
        PeniCalcPage peniCalc = new PeniCalcPage(driver);
        Helpers.ElementShouldBeVisible(driver, By.ClassName(peniCalc.PeniCalc));
    }
        
    /// <summary>
    /// Проверяем, что калькулятор Усн загрузился
    /// </summary>
    [Test]
    public void UsnCalculator_IsVisible_Success()
    {
        driver.Navigate().GoToUrl(LinksStorage.UsnCalcPageUrl);
        UsnCalcPage usnCalculator = new UsnCalcPage(driver);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(usnCalculator.UsnCalculator));
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
        Helpers.ElementShouldBeVisible(driver, By.Id(vacationCalc.Hint));
    }

    private void SuccessfulHospitalCalcCalculation(HospitalCalcPage hospitalCalc)
    {
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.DisabilityPeriodBegin),true);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.TodayButton),true);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.DisabilityPeriodEnd),true);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.TodayButton),true);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.InsuranceExperience),true);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.SubmitButton),true);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(hospitalCalc.NewCalculation),true);
    }
}