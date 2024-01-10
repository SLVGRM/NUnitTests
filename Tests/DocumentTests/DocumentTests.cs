using SeleniumAndNUnit.Documents;
using SeleniumAndNUnit.Infra;

namespace SeleniumAndNUnit.Tests.DocumentTests;

[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
public class DocumentTests : BaseTest
{
    /// <summary>
    /// Проверяем что большой док загружается за меньше 8 секунд
    /// </summary>
    [Test]
    public void OpenHugeDocument_LoadedInTime_Success()
    {
        driver.Navigate().GoToUrl(LinksStorage.HugeDocPageUrl);
        OpenedDocumentTests openedDocument = new OpenedDocumentTests(driver);
        Helpers.WaitVisibilityAndClickById(driver, openedDocument.PartOfDocument);
    }
}