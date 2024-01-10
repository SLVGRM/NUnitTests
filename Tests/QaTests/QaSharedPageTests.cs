﻿using FluentAssertions;
using OpenQA.Selenium;

namespace SeleniumAndNUnit;

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
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(qaSharedQuestionsPage.QaTag),false);
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(qaSharedQuestionsPage.QaHotTag),false);
    }
        
    /// <summary>
    /// Отображается меню
    /// </summary>
    [Test]
    public void QaSharedQuestionsPage_Menu_Visible()
    {
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(qaSharedQuestionsPage.QaNavMenuItem),false);
    }
        
    /// <summary>
    /// После клика "Еще вопросы" подгружается вторая страница с вопросами
    /// </summary>
    [Test]
    public void QaSharedQuestionsPage_ExpertAnswers_Visible()
    {
        int firstpageamount = driver.FindElements(By.CssSelector(qaSharedQuestionsPage.QaShortenQuestionForPublicUser)).Count;
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(qaSharedQuestionsPage.LoadingButton), true);
        int secondpageamount = driver.FindElements(By.CssSelector(qaSharedQuestionsPage.QaShortenQuestionForPublicUser)).Count;
        secondpageamount.Should().BeGreaterThan(firstpageamount);
    }
        
    /// <summary>
    /// После клика по открытому вопросу происходит переход в вопрос, проверяем что доступен ответ эксперта
    /// </summary>
    [Test]
    public void ClickOnSharedQuestion_ExpertAnswer_Visible()
    {
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(qaSharedQuestionsPage.QaShortenQuestionForPublicUser), true);
        Hellpers.ElementShouldBeVisible(driver, By.CssSelector(qaSharedQuestionsPage.QaMessageBody),false);
    }
}