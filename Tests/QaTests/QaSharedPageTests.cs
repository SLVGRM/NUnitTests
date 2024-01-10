using FluentAssertions;
using OpenQA.Selenium;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.QaTests;

[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
public class QaSharedQuestionsPageTests : BaseTest
{
    private QaSharedQuestionsPage qaSharedQuestionsPage;

    [SetUp]
    public void Setup()
    {
        qaSharedQuestionsPage = new QaSharedQuestionsPage(driver);
        qaSharedQuestionsPage.NavigateToUrl(LinksStorage.QaSharedQuestionsPageUrl);
    }
        
    /// <summary>
    /// Отображаются обычные и горячие теги
    /// </summary>
    [Test]
    public void QaSharedQuestionsPage_Tags_Visible()
    {
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaSharedQuestionsPage.QaTag);
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaSharedQuestionsPage.QaHotTag);
    }
        
    /// <summary>
    /// Отображается блок меню "Вопросы экспертам"
    /// </summary>
    [Test]
    public void QaSharedQuestionsPage_Menu_Visible()
    {
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaSharedQuestionsPage.QaNavMenuItem);
    }
        
    /// <summary>
    /// После клика "Еще вопросы" подгружается вторая страница с вопросами
    /// </summary>
    [Test]
    public void QaSharedQuestionsPage_ExpertAnswers_Visible()
    {
        int firstpageamount = driver.FindElements(By.CssSelector(qaSharedQuestionsPage.QaShortenQuestionForPublicUser)).Count;
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaSharedQuestionsPage.LoadingButton, true);
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaSharedQuestionsPage.LoadingButton);
        int secondpageamount = driver.FindElements(By.CssSelector(qaSharedQuestionsPage.QaShortenQuestionForPublicUser)).Count;
        secondpageamount.Should().BeGreaterThan(firstpageamount);
    }
        
    /// <summary>
    /// После клика по открытому вопросу происходит переход в вопрос, проверяем что доступен ответ эксперта
    /// </summary>
    [Test]
    public void ClickOnSharedQuestion_ExpertAnswer_Visible()
    {
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaSharedQuestionsPage.QaShortenQuestionForPublicUser, true);
        Helpers.WaitVisibilityAndClickByCssSelector(driver, qaSharedQuestionsPage.QaMessageBody);
    }
}