using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class QaSharedQuestionsPage : BasePage
    {
        public QaSharedQuestionsPage(IWebDriver driver) : base(driver)
        {
        }
        
        public IWebElement QuestionForPublicUser =>  FindElement(By.CssSelector("[data-tid='QaShortenQuestionForPublicUserBody']"));
        public IWebElement LoadingPageButton =>  FindElement(By.CssSelector("[data-tid='LoadingPageButton']"));
        
        
        public string QaHotTag = "[data-tid='QaHotTag']";
        public string QaTag = "[data-tid='QaTag']";
        public string QaShortenQuestionForPublicUser = "[data-tid='QaShortenQuestionForPublicUser']";
        public string QaNavMenuItem = "[data-tid='QaNavMenuItem']";
        public string QaMessageBody = "[data-tid='QaMessageBody']";
        public string LoadingButton = "[data-tid='LoadingPageButton']";
    }
}
