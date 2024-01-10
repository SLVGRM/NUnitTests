using OpenQA.Selenium;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit;

[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
public class AskQuestionPageTests : BaseTest
{
    private QaAskQuestionPage qaAskQuestionPage;
    
    [SetUp]
    public void Setup()
    {
        qaAskQuestionPage = new QaAskQuestionPage(driver);
        qaAskQuestionPage.NavigateToUrl(LinksStorage.QaAskQuestionPageUrl);
    }

    /// <summary>
    /// Успешное задание и удаление вопроса
    /// </summary>
    [Test]
    public void QaAskQuestionPage_AskAndDeleteQuestion_Success()
    {
        Helpers.BrowseByUser(driver, true);
        AskAndDeleteQuestion();
    }

    private void AskAndDeleteQuestion()
    {
        var text = "тестовый вопрос";
        Helpers.WaitAndSendKeys(driver, qaAskQuestionPage.QaAddQuestionBody, text);
        qaAskQuestionPage.QaAddQuestionTaxSystemOsno.Click(); 
        qaAskQuestionPage.QaAskQuestionLegalStatusSelector.Click();
        qaAskQuestionPage.QaAskQuestionLegalStatusOption.Click(); 
        qaAskQuestionPage.QaAskQuestionAccountPlanSelector.Click();
        qaAskQuestionPage.QaAskQuestionAccountPlanOption.Click();
        qaAskQuestionPage.QaAskQuestionAcceptTermCheckbox.Click();
        qaAskQuestionPage.QaAskQuestionSubmit.Click();
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(qaAskQuestionPage.QaAskQuestionOpenQuestionButton), true);
        Helpers.ElementShouldBeVisible(driver, By.CssSelector(qaAskQuestionPage.QaMessageDeleteButton), true);
        qaAskQuestionPage.QaDeleteMessagePopupSubmitButton.Click();
    }
}