using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaSharedQuestionsPage : BasePage
{
    public QaSharedQuestionsPage(IWebDriver driver) : base(driver)
    {
    }
        
    public IWebElement ShortenQuestionForPublicUserLink =>  FindElement(By.CssSelector("[data-tid='ShortenQuestionForPublicUserLink']"));
    public IWebElement LoadingPageButton =>  FindElement(By.CssSelector("[data-tid='LoadingPageButton']"));
        
        
    public readonly string QaHotTag = "[data-tid='QaHotTag']";
    public readonly string QaTag = "[data-tid='QaTag']";
    public readonly string QaShortenQuestionForPublicUser = "[data-tid='QaShortenQuestionForPublicUser']";
    public readonly string QaNavMenuItem = "[data-tid='QaNavMenuItem']";
    public readonly string QaMessageBody = "[data-tid='QaMessageBody']";
    public readonly string LoadingButton = "[data-tid='LoadingPageButton']";
}