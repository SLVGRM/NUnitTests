using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class Stubs : BaseTest
    {
        public string Turbostub => "[data-tid='TurboModeStub']";

        public Stubs(IWebDriver driver) : base()
        {
        }
    }
}