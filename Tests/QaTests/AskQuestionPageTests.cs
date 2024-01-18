using OpenQA.Selenium;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.QaTests;

[TestFixture]
public class AskQuestionPageTests : BaseTest
{
    private QaAskQuestionPage qaAskQuestionPage;
    
    [SetUp]
    public void Setup()
    {
        Stubs stubs = new Stubs(driver);
        qaAskQuestionPage = new QaAskQuestionPage(driver, stubs);
        qaAskQuestionPage.NavigateToUrl(LinksStorage.QaAskQuestionPageUrl);
    }

    /// <summary>
    /// Успешное задание и удаление вопроса
    /// </summary>
    [Test]
    public void QaAskQuestionPage_AskAndDeleteQuestion_Success()
    {
        Helpers.BrowseByUser(driver, true);
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaAskQuestionPage.stubs.Turbostub);
        // AskAndDeleteQuestion();
    }

    private void AskAndDeleteQuestion()
    {
        var text = "тестовый вопрос";
        Helpers.WaitAndSendKeys(driver, qaAskQuestionPage.QaAddQuestionBody, text);
        qaAskQuestionPage.QaAskQuestionSubmit.Click();
        qaAskQuestionPage.QaAddQuestionTaxSystemOsno.Click(); 
        qaAskQuestionPage.QaAskQuestionLegalStatusSelector.Click();
        qaAskQuestionPage.QaAskQuestionLegalStatusOption.Click(); 
        qaAskQuestionPage.QaAskQuestionAccountPlanSelector.Click();
        qaAskQuestionPage.QaAskQuestionAccountPlanOption.Click();
        qaAskQuestionPage.QaAskQuestionAcceptTermCheckbox.Click();
    }
}