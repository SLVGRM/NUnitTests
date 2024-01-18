using OpenQA.Selenium;

namespace SeleniumAndNUnit
{
    public class Stubs : BaseTest
    {
        public string Turbostub => "[data-tid='TurboModeStub']";
        public string PayTariffStub => "[data-tid='PayTariffStub']";
        public string UnAuthorizedStub => "[data-tid='UnAuthorizedStub']";
        public string UnAuthorizedStubModal => "[data-tid='UnAuthorizedStubModal']";
        public string ExpertsMethodicsNoAccess => "[data-tid='ExpertsMethodicsNoAccess']";
        

        public Stubs() : base()
        {
        }
    }
}