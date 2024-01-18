using OpenQA.Selenium;

namespace SeleniumAndNUnit;

public class QaAskQuestionPage : BasePage
{
    public Stubs stubs { get; }
    public QaAskQuestionPage(IWebDriver driver, Stubs stubs) : base(driver)
    {
        this.stubs = stubs;
    }
    
    public string QaAddQuestionBody = "[data-tid='QaAddQuestionBody']";
    public string QaAskQuestionOpenQuestionButton = "[data-tid='QaAskQuestionOpenQuestionButton']";
    public string QaMessageDeleteButton = "[data-tid='QaMessageDeleteButton'] button";
    
    public IWebElement QaAskQuestionLegalStatusSelector =>  FindElement(By.CssSelector("[data-tid='QaAskQuestionLegalStatus'] button"));
    public IWebElement QaAskQuestionLegalStatusOption =>  FindElement(By.CssSelector("[data-tid='QaAskQuestionLegalStatusItem'][data-text='Физическое лицо']"));
    public IWebElement QaAddQuestionTaxSystemOsno =>  FindElement(By.CssSelector("[data-tid='QaAddQuestionTaxSystemOsno']"));
    public IWebElement QaAskQuestionAcceptTermCheckbox =>  FindElement(By.CssSelector("[data-tid='QaAskQuestionAcceptTermCheckbox'] > div"));
    public IWebElement QaAskQuestionAccountPlanSelector =>  FindElement(By.CssSelector("[data-tid='QaAskQuestionAccountPlan'] button"));
    public IWebElement QaAskQuestionAccountPlanOption =>  FindElement(By.CssSelector("[data-tid='QaAskQuestionAccountPlanItem'][data-text='Общий']"));
    public IWebElement QaAskQuestionSubmit =>  FindElement(By.CssSelector("[data-tid='QaAskQuestionSubmit'] button"));
    public IWebElement QaDeleteMessagePopupSubmitButton =>  FindElement(By.CssSelector("[data-tid='QaDeleteMessagePopupSubmitButton'] button"));
}